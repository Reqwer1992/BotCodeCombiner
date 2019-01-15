using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MagicBotCodeCombiner
{
    public partial class Form1 : Form
    {
        private const string BotAssemblyName = "MagicBot";

        private readonly List<string> sourceFileList;

        public Form1()
        {
            InitializeComponent();

            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            var assemblyDirectoty = Path.GetDirectoryName(path);
            var combinerCodeDirectory = Path.GetFullPath(Path.Combine(assemblyDirectoty, @"..\..\..\"));
            var codeDirectory = Path.Combine(combinerCodeDirectory, BotAssemblyName);

            sourceFileList = FindAllCsFiles(codeDirectory);

            lblBaseDirectory.Text = codeDirectory;
            for (var i = 0; i < sourceFileList.Count; i++)
            {
                var fileName = sourceFileList[i].Substring(codeDirectory.Length, sourceFileList[i].Length - codeDirectory.Length);
                txtFileList.Text = txtFileList.Text + fileName + Environment.NewLine;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtUsings.Clear();
            txtCode.Clear();

            var usingsList = new HashSet<string>();

            foreach (var filename in sourceFileList)
            {
                var fileText = System.IO.File.ReadAllText(filename);

                var codeText = string.Empty;

                using (var reader = new StringReader(fileText))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null && line.StartsWith("using "))
                    {
                        if (line.StartsWith("using "))
                        {
                            usingsList.Add(line);
                        }
                        else
                        {
                            codeText = codeText + line + Environment.NewLine;
                            break;
                        }
                    }

                    while ((line = reader.ReadLine()) != null)
                    {
                        codeText = codeText + line + Environment.NewLine;
                    }
                }

                txtCode.Text = txtCode.Text + codeText + Environment.NewLine;
            }

            foreach (var usings in usingsList)
            {
                txtUsings.Text = txtUsings.Text + usings + Environment.NewLine;
            }
            
            Clipboard.SetText(txtUsings.Text + txtCode.Text);
        }

        private List<string> FindAllCsFiles(string baseDir)
        {
            var files = Directory.GetFiles(baseDir, "*.cs", SearchOption.AllDirectories);
            var result = files.ToList();
            result.RemoveAll(x => x.StartsWith(baseDir + @"\obj"));
            
            return result;
        }
    }
}
