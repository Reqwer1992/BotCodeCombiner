using System;
using System.Windows.Forms;

namespace MagicBotCodeCombiner
{
    public partial class CombinerForm : Form
    {
        // CHECK DefaultValues.cs

        public CombinerForm()
        {
            if (!DefaultValues.SPEEDTHINGSUPBOY)
            {
                InitializeComponent();
                txtBaseDirectory.Text = Utils.GetBaseDirectory(DefaultValues.BotAssemblyName);
                FillFileList();
                FillFileCode();
            }
            else
            {
                var baseDirectory = Utils.GetBaseDirectory(DefaultValues.BotAssemblyName);
                var fileList = Utils.GetFileList(baseDirectory, DefaultValues.IgnoreFileList);
                var fileContents = Utils.GetCombinedFileText(baseDirectory, fileList);
                Clipboard.SetText(fileContents.Item1 + fileContents.Item2);
                System.Environment.Exit(0);
            }
        }

        private string FillFileCode()
        {
            txtUsings.Clear();
            txtCode.Clear();

            var fileContents = Utils.GetCombinedFileText(txtBaseDirectory.Text, txtFileList.Text);
            txtUsings.Text = fileContents.Item1;
            txtCode.Text = fileContents.Item2;

            var fullCode = fileContents.Item1 + fileContents.Item2;

            return fullCode;
        }

        private void btnGetFileList_Click(object sender, EventArgs e)
        {
            FillFileList();
        }

        private void FillFileList()
        {
            txtFileList.Text = Utils.GetFileList(txtBaseDirectory.Text, DefaultValues.IgnoreFileList);
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            var code = FillFileCode();
            Clipboard.SetText(code);
        }

        private void btnCodeToIde_Click(object sender, EventArgs e)
        {
            var code = FillFileCode();
            CodeingameIdeSync.SendCommandToIde(CodingameIdeSyncCommandType.Code, code);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var code = FillFileCode();
            CodeingameIdeSync.SendCommandToIde(CodingameIdeSyncCommandType.Play, code);
        }

        private void btnPlaySameConditions_Click(object sender, EventArgs e)
        {
            var code = FillFileCode();
            CodeingameIdeSync.SendCommandToIde(CodingameIdeSyncCommandType.PlaySameConditions, code);
        }

        private void btnSubmitInIde_Click(object sender, EventArgs e)
        {
            var code = FillFileCode();
            CodeingameIdeSync.SendCommandToIde(CodingameIdeSyncCommandType.Submit, code);
        }
    }
}
