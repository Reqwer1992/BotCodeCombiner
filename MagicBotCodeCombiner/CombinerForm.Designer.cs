namespace MagicBotCodeCombiner
{
    partial class CombinerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.splTop = new System.Windows.Forms.Splitter();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.lblGenerateCode = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlaySameConditions = new System.Windows.Forms.Button();
            this.btnSubmitInIde = new System.Windows.Forms.Button();
            this.btnCodeToIde = new System.Windows.Forms.Button();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.btnGetFileList = new System.Windows.Forms.Button();
            this.txtBaseDirectory = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.pnlcode = new System.Windows.Forms.Panel();
            this.splCode = new System.Windows.Forms.Splitter();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.txtUsings = new System.Windows.Forms.RichTextBox();
            this.pnlTop.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.splTop);
            this.pnlTop.Controls.Add(this.pnlConfig);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1081, 123);
            this.pnlTop.TabIndex = 0;
            // 
            // splTop
            // 
            this.splTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.splTop.Location = new System.Drawing.Point(810, 0);
            this.splTop.Margin = new System.Windows.Forms.Padding(4);
            this.splTop.Name = "splTop";
            this.splTop.Size = new System.Drawing.Size(4, 123);
            this.splTop.TabIndex = 4;
            this.splTop.TabStop = false;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.lblGenerateCode);
            this.pnlConfig.Controls.Add(this.pnlButtons);
            this.pnlConfig.Controls.Add(this.btnGetFileList);
            this.pnlConfig.Controls.Add(this.txtBaseDirectory);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig.Margin = new System.Windows.Forms.Padding(4);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(814, 123);
            this.pnlConfig.TabIndex = 3;
            // 
            // lblGenerateCode
            // 
            this.lblGenerateCode.AutoSize = true;
            this.lblGenerateCode.Location = new System.Drawing.Point(12, 66);
            this.lblGenerateCode.Name = "lblGenerateCode";
            this.lblGenerateCode.Size = new System.Drawing.Size(171, 17);
            this.lblGenerateCode.TabIndex = 4;
            this.lblGenerateCode.Text = "Get code from files and...:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnPlay);
            this.pnlButtons.Controls.Add(this.btnPlaySameConditions);
            this.pnlButtons.Controls.Add(this.btnSubmitInIde);
            this.pnlButtons.Controls.Add(this.btnCodeToIde);
            this.pnlButtons.Controls.Add(this.btnClipboard);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 87);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(814, 36);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.Location = new System.Drawing.Point(241, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(163, 36);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Send and play in IDE";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlaySameConditions
            // 
            this.btnPlaySameConditions.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlaySameConditions.Location = new System.Drawing.Point(404, 0);
            this.btnPlaySameConditions.Name = "btnPlaySameConditions";
            this.btnPlaySameConditions.Size = new System.Drawing.Size(305, 36);
            this.btnPlaySameConditions.TabIndex = 3;
            this.btnPlaySameConditions.Text = "Send and play with same conditions in IDE";
            this.btnPlaySameConditions.UseVisualStyleBackColor = true;
            this.btnPlaySameConditions.Click += new System.EventHandler(this.btnPlaySameConditions_Click);
            // 
            // btnSubmitInIde
            // 
            this.btnSubmitInIde.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmitInIde.Location = new System.Drawing.Point(709, 0);
            this.btnSubmitInIde.Name = "btnSubmitInIde";
            this.btnSubmitInIde.Size = new System.Drawing.Size(105, 36);
            this.btnSubmitInIde.TabIndex = 4;
            this.btnSubmitInIde.Text = "Submit in IDE";
            this.btnSubmitInIde.UseVisualStyleBackColor = true;
            this.btnSubmitInIde.Click += new System.EventHandler(this.btnSubmitInIde_Click);
            // 
            // btnCodeToIde
            // 
            this.btnCodeToIde.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCodeToIde.Location = new System.Drawing.Point(137, 0);
            this.btnCodeToIde.Name = "btnCodeToIde";
            this.btnCodeToIde.Size = new System.Drawing.Size(104, 36);
            this.btnCodeToIde.TabIndex = 1;
            this.btnCodeToIde.Text = "Send to IDE";
            this.btnCodeToIde.UseVisualStyleBackColor = true;
            this.btnCodeToIde.Click += new System.EventHandler(this.btnCodeToIde_Click);
            // 
            // btnClipboard
            // 
            this.btnClipboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClipboard.Location = new System.Drawing.Point(0, 0);
            this.btnClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(137, 36);
            this.btnClipboard.TabIndex = 0;
            this.btnClipboard.Text = "Copy to clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // btnGetFileList
            // 
            this.btnGetFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileList.Location = new System.Drawing.Point(619, 27);
            this.btnGetFileList.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFileList.Name = "btnGetFileList";
            this.btnGetFileList.Size = new System.Drawing.Size(189, 30);
            this.btnGetFileList.TabIndex = 2;
            this.btnGetFileList.Text = "Get file list";
            this.btnGetFileList.UseVisualStyleBackColor = true;
            this.btnGetFileList.Click += new System.EventHandler(this.btnGetFileList_Click);
            // 
            // txtBaseDirectory
            // 
            this.txtBaseDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBaseDirectory.Location = new System.Drawing.Point(0, 0);
            this.txtBaseDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseDirectory.Name = "txtBaseDirectory";
            this.txtBaseDirectory.Size = new System.Drawing.Size(814, 22);
            this.txtBaseDirectory.TabIndex = 0;
            this.txtBaseDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFileList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(814, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 5;
            // 
            // txtFileList
            // 
            this.txtFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileList.Location = new System.Drawing.Point(0, 0);
            this.txtFileList.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileList.Multiline = true;
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileList.Size = new System.Drawing.Size(267, 123);
            this.txtFileList.TabIndex = 1;
            this.txtFileList.WordWrap = false;
            // 
            // pnlcode
            // 
            this.pnlcode.Controls.Add(this.splCode);
            this.pnlcode.Controls.Add(this.txtCode);
            this.pnlcode.Controls.Add(this.txtUsings);
            this.pnlcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcode.Location = new System.Drawing.Point(0, 123);
            this.pnlcode.Margin = new System.Windows.Forms.Padding(4);
            this.pnlcode.Name = "pnlcode";
            this.pnlcode.Size = new System.Drawing.Size(1081, 431);
            this.pnlcode.TabIndex = 1;
            // 
            // splCode
            // 
            this.splCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.splCode.Location = new System.Drawing.Point(0, 82);
            this.splCode.Margin = new System.Windows.Forms.Padding(4);
            this.splCode.Name = "splCode";
            this.splCode.Size = new System.Drawing.Size(1081, 4);
            this.splCode.TabIndex = 2;
            this.splCode.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 82);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(1081, 349);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "";
            this.txtCode.WordWrap = false;
            // 
            // txtUsings
            // 
            this.txtUsings.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsings.Location = new System.Drawing.Point(0, 0);
            this.txtUsings.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsings.Name = "txtUsings";
            this.txtUsings.Size = new System.Drawing.Size(1081, 82);
            this.txtUsings.TabIndex = 1;
            this.txtUsings.Text = "";
            this.txtUsings.WordWrap = false;
            // 
            // CombinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 554);
            this.Controls.Add(this.pnlcode);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CombinerForm";
            this.Text = "MagicBotCodeCombiner";
            this.pnlTop.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlcode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.Panel pnlcode;
        private System.Windows.Forms.TextBox txtFileList;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.RichTextBox txtUsings;
        private System.Windows.Forms.Splitter splTop;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Splitter splCode;
        private System.Windows.Forms.TextBox txtBaseDirectory;
        private System.Windows.Forms.Button btnGetFileList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblGenerateCode;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlaySameConditions;
        private System.Windows.Forms.Button btnSubmitInIde;
        private System.Windows.Forms.Button btnCodeToIde;
    }
}

