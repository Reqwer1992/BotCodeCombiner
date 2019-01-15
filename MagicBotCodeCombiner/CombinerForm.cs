using System;
using System.Windows.Forms;

namespace MagicBotCodeCombiner
{
    public partial class CombinerForm : Form
    {
        private const string BotAssemblyName = "MagicBotCodeCombiner";
        public const bool SPEEDTHINGSUPBOY = false; // just copy files contents to clipboard

        public CombinerForm()
        {
            if (!SPEEDTHINGSUPBOY)
            {
                InitializeComponent();
                txtBaseDirectory.Text = Utils.GetBaseDirectory(BotAssemblyName);
                FillFileList();
                FillFileCode();
            }
            else
            {
                var baseDirectory = Utils.GetBaseDirectory(BotAssemblyName);
                var fileList = Utils.GetFileList(baseDirectory);
                var fileContents = Utils.GetCombinedFileText(baseDirectory, fileList);
                Clipboard.SetText(fileContents.Item1 + fileContents.Item2);
                System.Environment.Exit(0);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FillFileCode();
        }

        private void FillFileCode()
        {
            txtUsings.Clear();
            txtCode.Clear();

            var fileContents = Utils.GetCombinedFileText(txtBaseDirectory.Text, txtFileList.Text);
            txtUsings.Text = fileContents.Item1;
            txtCode.Text = fileContents.Item2;

            Clipboard.SetText(fileContents.Item1 + fileContents.Item2);
        }

        private void btnGetFileList_Click(object sender, EventArgs e)
        {
            FillFileList();
        }

        private void FillFileList()
        {
            txtFileList.Text = Utils.GetFileList(txtBaseDirectory.Text);
        }
    }
}
