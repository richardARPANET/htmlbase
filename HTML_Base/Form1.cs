using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Base
{
    public partial class Form1 : Form
    {
        string folderPath = "";
        string resourcesFolder = "assets";
        string[] subFolders = new string[] { "images", "css", "js" };

        string reset_css = "html,body,div,span,applet,object,iframe,h1,h2,h3,h4,h5,h6,p,blockquote,pre,a,abbr,acronym,address,big,cite,code,del,dfn,em,font,img,ins,kbd,q,s,samp,small,strike,strong,sub,sup,tt,var,b,u,i,center,dl,dt,dd,ol,ul,li,fieldset,form,label,legend,table,caption,tbody,tfoot,thead,tr,th,td{margin:0;padding:0;border:0;outline:0;font-size:100%;vertical-align:baseline;background:transparent}body{line-height:1}ol,ul{list-style:none}blockquote,q{quotes:none}blockquote:before,blockquote:after,q:before,q:after{content:'';content:none}:focus{outline:0}ins{text-decoration:none}del{text-decoration:line-through}table{border-collapse:collapse;border-spacing:0}";
        string htmlStart = 
@"<!DOCTYPE html>
<html>
<head>
<meta charset=""utf-8"">
<title></title>
";
        string htmlEnd = 
@"
<link href=""assets/css/reset.css"" rel=""stylesheet"" type=""text/css"" />
<link href=""assets/css/master.css"" rel=""stylesheet"" type=""text/css"" />
</head>

<body>

</body>
</html>";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                if (folderPath != null)
                {
                    LiveLog("Selected folder: " + folderPath);
                    btnBuild.Visible = true;
                }
            }
        }

        public void LiveLog(string output)
        {
            this.BeginInvoke(new MethodInvoker(delegate()
            {
                lstOutput.Items.Add(output);
            }));

        }

        private string BuildFile()
        {
            //add extras into index file, js etc
            List<string> options = new List<string>();
            string additions = null;

            if(checkJquery.Checked == true) {
                options.Add("<script src=\"http://code.jquery.com/jquery.min.js\"></script>" + Environment.NewLine);
            }

            if (checkJqueryUi.Checked == true)
            {
                options.Add("<script src=\"http://code.jquery.com/ui/jquery-ui-git.js\"></script>" + Environment.NewLine);
                options.Add("<link rel=\"stylesheet\" type=\"text/css\" href=\"http://code.jquery.com/ui/jquery-ui-git.css\" />" + Environment.NewLine);   
            }

            if (checkModernizr.Checked == true)
            {
                options.Add("<script src=\"http://cdnjs.cloudflare.com/ajax/libs/modernizr/2.6.2/modernizr.min.js\"></script>" + Environment.NewLine);
            }

            foreach (string option in options) {
                additions += option;
            }


            return htmlStart + additions + htmlEnd;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            //Create a new subfolder under the current active folder 
            string newPath = System.IO.Path.Combine(folderPath, resourcesFolder);

            // Create the subfolder
            if (!System.IO.Directory.Exists(newPath))
            {
                System.IO.Directory.CreateDirectory(newPath);
            }
            
            //make index file
            makeFile(folderPath, "index.html", BuildFile());

            //place files
            foreach (string folder in subFolders)
            {

                string subFolderPath = System.IO.Path.Combine(newPath, folder);
                System.IO.Directory.CreateDirectory(subFolderPath);

                
                if (folder == "css")
                {
                    string[] newFiles = new string[] { "master.css", "reset.css" };
                    foreach (string file in newFiles)
                    {
                        if (file == "reset.css")
                        {
                            string content = reset_css;
                            makeFile(subFolderPath, file, content);
                        }
                        else
                        {
                            makeFile(subFolderPath, file, null);
                        }
                    }
                }
            } //for

            LiveLog("Build complete.");
        }

        private void makeFile(string path, string filename, string content)
        {
            string filePath = System.IO.Path.Combine(path, filename);

            if (!System.IO.File.Exists(filePath))
            {
                if (content == null)
                {
                    System.IO.File.Create(filePath);
                    Console.Write(filePath);
                }
                else
                {
                    System.IO.File.AppendAllText(filePath, content);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



    }
}
