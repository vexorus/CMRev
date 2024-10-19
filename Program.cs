using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CMRev
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else if (args.Length >= 1)
                {
                    string configPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CMRev.txt";
                    if (File.Exists(configPath))
                    {
                        string[] configData = File.ReadAllLines(configPath);
                        string IDA64path = configData[0];
                        string IDA32path = configData[1];
                        string dnSpy32path = configData[2];
                        string dnSpy64path = configData[3];
                        string DIEpath = configData[4];
                        bool DIErun = false;
                        if (configData[5] == "True")
                        {
                            DIErun = true;
                        }
                        string filePath = args[0];
                        string fileType = GetTypeFile(File.ReadAllBytes(filePath));
                        if (DIErun)
                        {
                            Process.Start(DIEpath, filePath);
                        }
                        switch (fileType)
                        {
                            case "ELF32":
                                Process.Start(IDA32path, filePath);
                                break;
                            case "ELF64":
                                Process.Start(IDA64path, filePath);
                                break;
                            case "PE64":
                                if (IsNET(File.ReadAllText(filePath)))
                                {
                                    Process.Start(dnSpy64path, filePath);
                                }
                                else
                                {
                                    Process.Start(IDA64path, filePath);
                                }
                                break;
                            case "PE32":
                                if (IsNET(File.ReadAllText(filePath)))
                                {
                                    Process.Start(dnSpy32path, filePath);
                                }
                                else
                                {
                                    Process.Start(IDA32path, filePath);
                                }
                                break;
                            default:
                                MessageBox.Show("Invalid file type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Config file not found. Please run the program without arguments and configure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
            }
        }
        static private string GetTypeFile(byte[] data)
        {
            try
            {
                if (data[0] == 0x7F &&
                data[1] == 0x45 &&
                data[2] == 0x4C &&
                data[3] == 0x46)
                {
                    if (data[4] == 1)
                    {
                        return "ELF32";
                    }
                    else if (data[4] == 2)
                    {
                        return "ELF64";
                    }
                }
                if (data[0] == 'M' &&
                    data[1] == 'Z')
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i] == 'P' && data[i + 1] == 'E')
                        {
                            if (data[i + 4] == 'd')
                            {
                                return "PE64";
                            }
                            else if (data[i + 4] == 'L')
                            {
                                return "PE32";
                            }
                        }
                    }
                }
                return "invalid";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
                return "null";
            }   
        }
        static private bool IsNET(string data)
        {
            try
            {
                int offsetPE = data.IndexOf("\0\0PE\0\0");
                return Convert.ToChar(data[offsetPE + 238]) == 'H' && Convert.ToChar(data[offsetPE + 263]) == ' ';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
                return false;
            }
            
        }
    }
}
