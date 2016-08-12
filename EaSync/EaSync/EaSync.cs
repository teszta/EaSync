using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace EaSync
{
    public partial class EaSync : Form
    {
        public EaSync()
        {
            InitializeComponent();
            var Parser = new IniParser("config.ini");
            if (!Parser.KeyExists("SyncLocation"))
            {
                Parser.Write("SyncLocation", "C:\\Users\\" + Environment.UserName + "\\Music");
            }
            if (!Parser.KeyExists("DestLocation"))
            {
                Parser.Write("DestLocation", "C:\\Music");
            }
            if (!Parser.KeyExists("LastSync"))
            {
                Parser.Write("LastSync", "0");
            }
            if (!Parser.KeyExists("Ext"))
            {
                Parser.Write("Ext", ".mp3");
            }
            Lista.Items.Add("Welcome to EaSync!");
            if (Parser.Read("LastSync") == "0")
            {
                Lista.Items.Add("You haven't syncronized yet.");
                Lista.Items.Add("Set up the folders and let's get started! :)");
            }
            else
            {
                Lista.Items.Add("Your last syncronization was at " + Parser.Read("LastSync"));
            }
            SyncFolder.Text = Parser.Read("SyncLocation");
            DestinationFolder.Text = Parser.Read("DestLocation");
            ExtBox.Text = Parser.Read("Ext");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            var Parser = new IniParser("config.ini");
            Lista.Items.Clear();
            progressBar.Value = 0;
            Thread.Sleep(100);
            if (ExtBox.Text == "")
            {
                MessageBox.Show("Type an extension first. (eg.: .mp3 , .mp4 , .mkv)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                Lista.Items.Add("Aborted..");
                return;
            }
            try
            {
                Directory.GetFiles(SyncFolder.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Syncing folder must be a valid path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Lista.Items.Add("Aborted..");
                SyncFolder.Focus();
                return;
            }
            try
            {
                Directory.GetFiles(DestinationFolder.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Destination must be a valid path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Lista.Items.Add("Aborted..");
                DestinationFolder.Focus();
                return;
            }
            int SfilesCount = Directory.GetFiles(SyncFolder.Text, "*" + ExtBox.Text).Length;
            string[] SyncFiles = Directory.GetFiles(SyncFolder.Text, "*" + ExtBox.Text);
            int synced = 0;
            int already = 0;
            progressBar.Maximum = SfilesCount;
            progressBar.Step = 1;
            Lista.SelectionMode = SelectionMode.One;
            Cursor.Current = Cursors.WaitCursor;
            Thread.Sleep(500);
            for (int i = 0; i < SfilesCount; i++)
            {
                string s = Path.Combine(DestinationFolder.Text, SyncFiles[i].Substring(SyncFiles[i].LastIndexOf('\\') + 1));
                try
                {
                    File.Copy(SyncFiles[i], s);
                    Thread.Sleep(10);
                    Lista.Items.Add("File synced: " + SyncFiles[i].Substring(SyncFiles[i].LastIndexOf('\\') + 1));
                    Lista.SelectedIndex = synced;
                    progressBar.PerformStep();
                    synced++;
                }
                catch (Exception)
                {
                    progressBar.PerformStep();
                    already++;
                }
                Thread.Sleep(10);

            }
            if (synced != 0)
            {
                Lista.Items.Add("..");
            }
            Lista.Items.Add("Finished!");
            Lista.Items.Add(synced + " file(s) newly synced and " + already + " file(s) already synced of all " + SfilesCount + " with " + ExtBox.Text + " extension.");
            Lista.Items.Add("");
            if (synced == 0)
            {
                Lista.SelectionMode = SelectionMode.None;
            }
            else
            {
                Lista.SelectedIndex = synced + 3;
            }
            Cursor.Current = DefaultCursor;
            Parser.Write("LastSync", DateTime.Now.ToString());

        }

        private void SyncBtn_Click(object sender, EventArgs e)
        {
            var Parser = new IniParser("config.ini");
            SyncFolderSelector.Description = "Select the syncronization folder where you want to syncronize from.";
            SyncFolderSelector.ShowDialog();
            if (SyncFolderSelector.SelectedPath != "")
            {
                SyncFolder.Text = SyncFolderSelector.SelectedPath;
                Parser.Write("SyncLocation", SyncFolderSelector.SelectedPath);

            }
        }

        private void DestBtn_Click(object sender, EventArgs e)
        {
            var Parser = new IniParser("config.ini");
            DestFolderSelector.Description = "Select the destination folder where you want to syncronize your files.";
            DestFolderSelector.ShowDialog();
            if (DestFolderSelector.SelectedPath != "")
            {
                DestinationFolder.Text = DestFolderSelector.SelectedPath;
                Parser.Write("DestLocation", DestFolderSelector.SelectedPath);

            }

        }
    }
}
