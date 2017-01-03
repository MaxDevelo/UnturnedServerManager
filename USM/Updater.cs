﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USM
{
    public partial class Updater : Form
    {
        public const string USMVersionDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/USMVer.dat";
        public const string UnturnedVersionDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/UntVer.dat";
        public const string RocketVersionDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/RocVer.dat";
        public const string PIVersionDownload = "https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/PIVer.dat";
        string[] Data;
        string[] InstalledData;
        public Updater()
        {
            InitializeComponent();
            Downloader.GetReady();

            if (File.Exists(Comms.DataPath + "Versions.dat") == true)
            {
                File.Delete(Comms.DataPath + "Versions.dat");
            }
            Downloader.Download(USMVersionDownload, "Versions.dat");
            Downloader.MoveFiles("Versions.dat", Comms.DataPath + "Versions.dat");
            Downloader.Download(UnturnedVersionDownload, "Unt.dat");
            Downloader.Download(RocketVersionDownload, "Roc.dat");
            Downloader.Download(PIVersionDownload, "PI.dat");
            string[] USMVersion = File.ReadAllLines(Comms.DataPath + "Versions.dat");
            string[] UnturnedVersion = File.ReadAllLines(Downloader.Temp + @"\Unt.dat");
            string[] RocketVersion = File.ReadAllLines(Downloader.Temp + @"\Roc.dat");
            string[] PIVersion = File.ReadAllLines(Downloader.Temp + @"\PI.dat");
            Data = new string[4];
            Data[0] = USMVersion[0];
            Data[1] = UnturnedVersion[0];
            Data[2] = RocketVersion[0];
            Data[3] = PIVersion[0];
            if (File.Exists(Comms.DataPath + "Installed.dat") == true)
            {
                InstalledData = File.ReadAllLines(Comms.DataPath + "Installed.dat");
            }
            else if (File.Exists(Comms.DataPath + "Installed.dat") == false)
            {
                InstalledData = new string[3];
                InstalledData[0] = "Custom";
                InstalledData[1] = "N/A";
                InstalledData[2] = "N/A";
            }
            LoadVersions();
            DisableUpdates();
        }
        
        private async void DisableUpdates()
        {
            int c = 0;
            while (c < 500)
            {
                if (Comms.AServerIsRunning == true)
                {
                    UUnturned.Enabled = false;
                    URocket.Enabled = false;
                    UAll.Enabled = false;
                }
                else if (Comms.AServerIsRunning == false)
                {
                    UUnturned.Enabled = true;
                    URocket.Enabled = true;
                    UAll.Enabled = true;
                }
                await Task.Delay(1);
            }
        }

        private void LoadVersions()
        {
            LMVer.Text = Data[0];
            LUVer.Text = Data[1];
            LRVer.Text = Data[2];
            LPIVer.Text = Data[3];
            if (File.Exists(Comms.DataPath + "Installed.dat") == true)
            {
                try
                {
                    CUVer.Text = InstalledData[0];
                    CRVer.Text = InstalledData[1];
                    CPIVer.Text = InstalledData[2];
                }
                catch (IndexOutOfRangeException)
                {
                    // Ignore
                }
            }
        }

        private void UUnturned_Click(object sender, EventArgs e)
        {
            bool SuccessInstall = Downloader.InstallUnturned();
            if (SuccessInstall == false)
            {
                MessageBox.Show("An error has occured during the update of unturned. Please manually update unturned.");
            }
            else if (SuccessInstall == true)
            {
                InstalledData[0] = Data[1];
                CUVer.Text = InstalledData[0];
                MessageBox.Show("Unturned has been successfully isntalled/updated.");
            }
        }

        private void URocket_Click(object sender, EventArgs e)
        {
            bool SuccessInstall = Downloader.InstallRocket();
            if (SuccessInstall == false)
            {
                MessageBox.Show("An error has occured during the update of rocket. Please manually update rocket.");
            }
            else if (SuccessInstall == true)
            {
                InstalledData[1] = Data[2];
                CRVer.Text = InstalledData[1];
                MessageBox.Show("Rocket has been successfully isntalled/updated.");
            }
        }

        private void UPI_Click(object sender, EventArgs e)
        {
            bool SuccessInstall = Downloader.InstallIntegrity();
            if (SuccessInstall == false)
            {
                MessageBox.Show("An error has occured during the update of the plugin integrity.");
            }
            else if (SuccessInstall == true)
            {
                InstalledData[2] = Data[3];
                CPIVer.Text = InstalledData[2];
                MessageBox.Show("Plugin Integrity has been successfully isntalled/updated.");
            }
        }

        private void UAll_Click(object sender, EventArgs e)
        {
            bool SuccessInstall = Downloader.InstallUnturned();
            if (SuccessInstall == false)
            {
                MessageBox.Show("An error has occured during the update of unturned. Please manually update unturned.");
            }
            else if (SuccessInstall == true)
            {
                InstalledData[0] = Data[1];
            }

            bool SuccessInstall2 = Downloader.InstallRocket();
            if (SuccessInstall2 == false)
            {
                MessageBox.Show("An error has occured during the update of rocket. Please manually update rocket.");
            }
            else if (SuccessInstall2 == true)
            {
                InstalledData[1] = Data[2];
                CRVer.Text = InstalledData[1];
            }

            bool SuccessInstall3 = Downloader.InstallIntegrity();
            if (SuccessInstall3 == false)
            {
                MessageBox.Show("An error has occured during the update of the plugin integrity.");
            }
            else if (SuccessInstall3 == true)
            {
                InstalledData[2] = Data[3];
                CPIVer.Text = InstalledData[2];
            }

            Process.Start("https://github.com/persiafighter/UnturnedServerManager/blob/master/Data/USM.exe");
        }

        private void USM_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/persiafighter/UnturnedServerManager/blob/master/Data/USM.exe");
        }

        private void Updater_FormClosing(object sender, FormClosingEventArgs e)
        {
            Downloader.ShutOff();
            if (File.Exists(Comms.DataPath + "Installed.dat") == true)
            {
                File.Delete(Comms.DataPath + "Installed.dat");
            }
            File.WriteAllLines(Comms.DataPath + "Installed.dat", InstalledData);
            Close();
        }
    }
}
