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
            this.txtBaseDirectory = new System.Windows.Forms.TextBox();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlcode = new System.Windows.Forms.Panel();
            this.splCode = new System.Windows.Forms.Splitter();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.txtUsings = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetFileList = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlcode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.splTop);
            this.pnlTop.Controls.Add(this.pnlConfig);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // splTop
            // 
            this.splTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.splTop.Location = new System.Drawing.Point(597, 0);
            this.splTop.Name = "splTop";
            this.splTop.Size = new System.Drawing.Size(3, 100);
            this.splTop.TabIndex = 4;
            this.splTop.TabStop = false;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.btnGetFileList);
            this.pnlConfig.Controls.Add(this.txtBaseDirectory);
            this.pnlConfig.Controls.Add(this.btnGenerate);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(600, 100);
            this.pnlConfig.TabIndex = 3;
            // 
            // txtBaseDirectory
            // 
            this.txtBaseDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBaseDirectory.Location = new System.Drawing.Point(0, 0);
            this.txtBaseDirectory.Name = "txtBaseDirectory";
            this.txtBaseDirectory.Size = new System.Drawing.Size(600, 20);
            this.txtBaseDirectory.TabIndex = 0;
            this.txtBaseDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFileList
            // 
            this.txtFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileList.Location = new System.Drawing.Point(0, 0);
            this.txtFileList.Multiline = true;
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileList.Size = new System.Drawing.Size(200, 100);
            this.txtFileList.TabIndex = 1;
            this.txtFileList.WordWrap = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerate.Location = new System.Drawing.Point(0, 77);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(600, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate code and copy to clipboard";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlcode
            // 
            this.pnlcode.Controls.Add(this.splCode);
            this.pnlcode.Controls.Add(this.txtCode);
            this.pnlcode.Controls.Add(this.txtUsings);
            this.pnlcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcode.Location = new System.Drawing.Point(0, 100);
            this.pnlcode.Name = "pnlcode";
            this.pnlcode.Size = new System.Drawing.Size(800, 350);
            this.pnlcode.TabIndex = 1;
            // 
            // splCode
            // 
            this.splCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.splCode.Location = new System.Drawing.Point(0, 67);
            this.splCode.Name = "splCode";
            this.splCode.Size = new System.Drawing.Size(800, 3);
            this.splCode.TabIndex = 2;
            this.splCode.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 67);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(800, 283);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "";
            this.txtCode.WordWrap = false;
            // 
            // txtUsings
            // 
            this.txtUsings.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsings.Location = new System.Drawing.Point(0, 0);
            this.txtUsings.Name = "txtUsings";
            this.txtUsings.Size = new System.Drawing.Size(800, 67);
            this.txtUsings.TabIndex = 1;
            this.txtUsings.Text = "";
            this.txtUsings.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFileList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // btnGetFileList
            // 
            this.btnGetFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileList.Location = new System.Drawing.Point(454, 22);
            this.btnGetFileList.Name = "btnGetFileList";
            this.btnGetFileList.Size = new System.Drawing.Size(142, 24);
            this.btnGetFileList.TabIndex = 2;
            this.btnGetFileList.Text = "Get file list";
            this.btnGetFileList.UseVisualStyleBackColor = true;
            this.btnGetFileList.Click += new System.EventHandler(this.btnGetFileList_Click);
            // 
            // CombinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlcode);
            this.Controls.Add(this.pnlTop);
            this.Name = "CombinerForm";
            this.Text = "MagicBotCodeCombiner";
            this.pnlTop.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.pnlcode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnGenerate;
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
    }
}

