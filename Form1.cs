using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMRev
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void metroButtonIDA64path_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "EXE|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                TextBoxIDA64path.Text = str;
            }
        }
        private void metroButtonIDA32path_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "EXE|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                TextBoxIDA32path.Text = str;
            }
        }
        private void metroButtonDnSpy64path_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "EXE|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                TextBoxDnSpy64path.Text = str;
            }
        }
        private void metroButtonDnSpy32path_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "EXE|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                TextBoxDnSpy32path.Text = str;
            }
        }
        private void metroButtonDIEpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "EXE|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                TextBoxDIEpath.Text = str;
            }
        }
        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckTextBoxes())
                {
                    return;
                }
                string configPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CMRev.txt";
                string[] configData = { TextBoxIDA64path.Text, TextBoxIDA32path.Text, TextBoxDnSpy64path.Text, TextBoxDnSpy32path.Text, TextBoxDIEpath.Text, CheckBoxDIE.Checked.ToString() };
                File.WriteAllLines(configPath, configData);

                if (!IsAdmin())
                {
                    MetroFramework.MetroMessageBox.Show(this, $"The program will restart with administrator rights. After restarting, press the button again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RunAsAdmin(Assembly.GetExecutingAssembly().Location, "");
                    Process.GetCurrentProcess().Kill();
                }
                RegistryKey regKey = Registry.ClassesRoot.OpenSubKey("*").OpenSubKey("shell", true).CreateSubKey("CMRev");
                regKey.SetValue("Icon", $"\"{Assembly.GetExecutingAssembly().Location}\"");
                regKey = regKey.CreateSubKey("Command");
                regKey.SetValue("", $"\"{Assembly.GetExecutingAssembly().Location}\" \"%1\"");
                MetroFramework.MetroMessageBox.Show(this, "Success. CMRev added to context menu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
            }
        }
        private bool CheckTextBoxes()
        {
            MetroFramework.Controls.MetroTextBox[] textBoxes = { TextBoxIDA64path, TextBoxIDA32path, TextBoxDnSpy64path, TextBoxDnSpy32path, TextBoxDIEpath };
            foreach (MetroFramework.Controls.MetroTextBox textBox in textBoxes)
            {
                if (textBox.Text.Trim() == String.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, $"{textBox.Tag} empty field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!File.Exists(textBox.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, $"\"{textBox.Text}\" path not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string configPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CMRev.txt";
                if (File.Exists(configPath))
                {
                    string[] configData = File.ReadAllLines(configPath);
                    TextBoxIDA64path.Text = configData[0];
                    TextBoxIDA32path.Text = configData[1];
                    TextBoxDnSpy64path.Text = configData[2];
                    TextBoxDnSpy32path.Text = configData[3];
                    TextBoxDIEpath.Text = configData[4];
                    if (configData[5] == "True")
                    {
                        CheckBoxDIE.Checked = true;
                    }
                    else
                    {
                        CheckBoxDIE.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
            }
            
        }
        private void metroButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey regKey = Registry.ClassesRoot.OpenSubKey("*").OpenSubKey("shell", true);
                regKey.DeleteSubKeyTree("CMRev");
                MetroFramework.MetroMessageBox.Show(this, "Success. CMRev removed from context menu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }
        private static void RunAsAdmin(string aFileName, string anArguments)
        {
            try
            {
                ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();

                processInfo.FileName = aFileName;
                processInfo.Arguments = anArguments;
                processInfo.UseShellExecute = true;
                processInfo.Verb = "runas";

                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
            }
            
        }
        private static bool IsAdmin()
        {
            try
            {
                System.Security.Principal.WindowsIdentity id = System.Security.Principal.WindowsIdentity.GetCurrent();
                System.Security.Principal.WindowsPrincipal p = new System.Security.Principal.WindowsPrincipal(id);

                return p.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
                return false;
            }
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/vexorus");
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/vexorus/CMRev");
        }
    }
}
