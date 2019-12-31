using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZStdTool
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            else
            {
                string cmd = args[0];
                if (cmd == "/s" || cmd == "/r")
                {
                    try
                    {
                        ShellIntergration.Set(cmd == "/s");
                    }
                    catch
                    {
                        MessageBox.Show("Please run with admin!", "Permission denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (cmd == "/c" || cmd == "/d")
                {
                    try
                    {
                        string file = args[1];
                        if (cmd == "/c")
                            ZstdWrapper.CompressFile(file);
                        else
                            ZstdWrapper.DecompressFile(file);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
