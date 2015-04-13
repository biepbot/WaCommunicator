﻿using System;
using System.ServiceProcess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace WaCommunicator
{
    public partial class Form1 : Form
    {
        #region Initialising of fields, a few for options, others for quick use
        //Fields
        private string serviceName = "Wacom Professional Service_";
        private int timeoutMilliseconds;
        private int loops;
        private ServiceController service;
        private bool clickToRestart;
        private bool startMinimised;
        private bool TEMPstartMinimised;
        private bool restartOnPlugIn = true;
        #endregion

        #region Constructor and loading of options
        //Constructor (empty)
        public Form1()
        { 
            InitializeComponent();

            //Open option file and read it
            try
            {
                using (FileStream stream = new FileStream("WaCommunicatorOptions", FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        clickToRestart = reader.ReadBoolean();
                        startMinimised = reader.ReadBoolean();
                        restartOnPlugIn = reader.ReadBoolean();
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Init
            rTB_output.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss") + " - User detected, settings loaded";
            timeoutMilliseconds = Convert.ToInt32(nUD_timeout.Value);
            loops = 0;

            //Set checks
            backgroundWorker.RunWorkerAsync();
            defaultRestartUponTrayClickToolStripMenuItem.Checked = clickToRestart;
            restartServiceUponUSBPlugInToolStripMenuItem.Checked = restartOnPlugIn;
            startApplicationMinimisedToolStripMenuItem.Checked = startMinimised;
            TEMPstartMinimised = startMinimised;
        }
        #endregion

        #region Form visibility methods
        //Don't show form if startMinimised is true
        protected override void SetVisibleCore(bool value)
        {
            if (TEMPstartMinimised)
            {
                TEMPstartMinimised = false;
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //True minimise override
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }
        #endregion

        #region Button configuration
        private void btn_restart_service_Click(object sender, EventArgs e)
        {
            //On press, restart
            service = new ServiceController(serviceName);
            Restart(Convert.ToInt32(nUD_timeout.Value));
        }
        #endregion

        #region Inner functional methods; restarting and debugging
        public void Restart(int timeoutms, int wait = 0)
        {
            //Check the amount of loops of the catch
            if (loops <= 4)
            {
                loops++;
                if (loops == 1) { Newline("Initialising service '" + serviceName + "' restart with timeout set " + Convert.ToString(timeoutms) + "..."); }
                else { Newline("An error has occurred, retrying! Retry number: " + loops + " out of 5"); }

                //Try restarting
                try
                {
                    System.Threading.Thread.Sleep(wait);

                    //Start by stopping the service and both set and count timeouts
                    Newline("Initialisement successful");
                    Newline("Processing kill stage");
                    int millisec1 = Environment.TickCount;
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutms);

                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    Newline("Service: " + serviceName + " successfully stopped");

                    System.Threading.Thread.Sleep(500);

                    //count the rest of the timeout
                    int millisec2 = Environment.TickCount;
                    timeout = TimeSpan.FromMilliseconds(timeoutms - (millisec2 - millisec1));
                    Newline("Processing reboot stage...");

                    //start the service again
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                    Newline("Service: " + serviceName + " successfully launched");
                    Newline("Done and ready to go!");

                    NotifyIcon.ShowBalloonTip(3000, "Wacom driver restarted!", "Give it time to load resources fully...", ToolTipIcon.Info);
                }
                catch (Exception ex)
                {
                    //If an exception occurred, show which exception in the console
                    Newline("Something went wrong:");
                    Newline("\"" + ex.Message + "\"");
                    //If it is due to a lack of rights, then don't loop
                    if (ex.Message.Contains("Cannot open") && ex.Message.Contains("service on computer '.'."))
                    { 
                        Newline("Are you running the application with administrator rights?");
                        loops = 0;

                        NotifyIcon.ShowBalloonTip(3000, "Not enough rights!", "Run the application with admin rights", ToolTipIcon.Warning);
                    }
                    else
                    {
                        //If the service does not exist
                        if (ex.Message.Contains("was not found on computer"))
                        {
                            //Show said service, and ask for validation
                            Newline("Is the '" + serviceName + "' service installed (correctly)?");

                            NotifyIcon.ShowBalloonTip(3000, "Service not found!", "Is the service present?", ToolTipIcon.Error);
                        }
                        else
                        {
                            //Else try again
                            Restart(Convert.ToInt32(nUD_timeout.Value));

                            NotifyIcon.ShowBalloonTip(3000, "Failed to restart", "Trying again...", ToolTipIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                //After 5 fails, stop retrying
                Newline("Failed to restart after 5 tries");
                loops = 0;

                NotifyIcon.ShowBalloonTip(3000, "Failed to restart!", "Check log for errors", ToolTipIcon.Error);
            }
        }

        public void Newline(string text)
        {
            //Write information lines with time
            text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss") + " - " + text;
            rTB_output.Text += Environment.NewLine + text; 
        }
        #endregion

        #region Tray icon configuration

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            //Open form upon doubleclick (unless restart on click is enabled, due to conflicts)
            if (!clickToRestart)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            //Create a mousebutton identifier
            MouseEventArgs me = (MouseEventArgs)e;

            //If right mouse button is pressed, open up the options
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip.Show();
            }

            //If the left mouse button is pressed, and the option is enabled; restart
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (clickToRestart)
                {
                    RestartTray(sender, e);
                }
            }
        }
        #endregion

        #region Context Strip Menu options

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show form
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void RestartTray(object sender, EventArgs e)
        {
            //Identify the sender, set the timeout settings
            int ms = 2500;
            if (sender.ToString() == "Minimum timeout") { ms = 5000; }
            if (sender.ToString() == "5s timeout") { ms = 1500; }
            string a = sender.ToString();

            //Notify the user
            NotifyIcon.ShowBalloonTip(3000, "Restarting the driver", "Please wait!", ToolTipIcon.Info);

            //Initialise restart
            service = new ServiceController(serviceName);
            Restart(ms);
        }
        #endregion

        #region Saving and changing options
        private void IdentifySaver(object sender, EventArgs e)
        {
            string test = sender.ToString();
            if (sender.ToString() == "Default restart upon tray click")
            {
                EditAndSaveOptions(clickToRestart, defaultRestartUponTrayClickToolStripMenuItem);
                return;
            }
            if (sender.ToString() == "Start application minimised")
            {
                EditAndSaveOptions(startMinimised, startApplicationMinimisedToolStripMenuItem);
                return;
            }
            if (sender.ToString() == "Restart service upon USB plug in")
            {
                EditAndSaveOptions(restartOnPlugIn, restartServiceUponUSBPlugInToolStripMenuItem);
                return;
            }
        }

        private void EditAndSaveOptions(bool option, ToolStripMenuItem tSMI)
        {
            //check current status, fix gui status
            if (option)
            {
                tSMI.Checked = false;
            }
            else
            {
                tSMI.Checked = true;
            }
            //fix inner status
            option = tSMI.Checked;
            //write to file
            using (FileStream stream = new FileStream("WaCommunicatorOptions", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(defaultRestartUponTrayClickToolStripMenuItem.Checked);
                    writer.Write(startApplicationMinimisedToolStripMenuItem.Checked);
                    writer.Close();
                }
            }
        }
        #endregion

        #region Detect USB plug in

        private void DeviceEvent(object sender, EventArrivedEventArgs e)
        {
            //If the restart on plug in option is checked, check if right USB device is connected, then restart
            if (restartOnPlugIn)
            {
                if (IsUsbDeviceConnected("0084"/*, "056A") ||IsUsbDeviceConnected("0084", "0302"*/))
                {
                    //Notify the user of said restart
                    NotifyIcon.ShowBalloonTip(3000, "USB Device recognised", "Please wait!", ToolTipIcon.Info);
                    service = new ServiceController(serviceName);
                    Restart(2500, 1000);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Set up the query upon activation
            WqlEventQuery insertQuery = new WqlEventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_PointingDevice'");

            //Create a watcher to trigger
            ManagementEventWatcher insertWatcher = new ManagementEventWatcher(insertQuery);
            insertWatcher.EventArrived += new EventArrivedEventHandler(DeviceEvent);
            //Start the watcher
            insertWatcher.Start();

            //Do something while waiting for events
            System.Threading.Thread.Sleep(200000000);
        }

        public bool IsUsbDeviceConnected(/*string productid,*/ string vendorid)
        {
            //Set assembly and query
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBControllerDevice"))
            {
                //Invoke the query
                using (var collection = searcher.Get())
                {
                    //Find the device with said productID and vendorID
                    foreach (var device in collection)
                    {
                        var usbDevice = Convert.ToString(device);
                        if (/*usbDevice.Contains(productid) &&*/ usbDevice.Contains(vendorid))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        #endregion
    }
}