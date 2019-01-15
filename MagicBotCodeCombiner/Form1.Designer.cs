namespace MagicBotCodeCombiner
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaseDirectory = new System.Windows.Forms.Label();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.txtUsings = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBaseDirectory);
            this.panel1.Controls.Add(this.txtFileList);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblBaseDirectory
            // 
            this.lblBaseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaseDirectory.Location = new System.Drawing.Point(362, 1);
            this.lblBaseDirectory.Name = "lblBaseDirectory";
            this.lblBaseDirectory.Size = new System.Drawing.Size(223, 20);
            this.lblBaseDirectory.TabIndex = 2;
            this.lblBaseDirectory.Text = "Path to code";
            this.lblBaseDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileList
            // 
            this.txtFileList.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFileList.Location = new System.Drawing.Point(587, 0);
            this.txtFileList.Multiline = true;
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileList.Size = new System.Drawing.Size(213, 77);
            this.txtFileList.TabIndex = 1;
            this.txtFileList.WordWrap = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerate.Location = new System.Drawing.Point(0, 77);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(800, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate code & copy to clipboard";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.txtUsings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MagicBotCodeCombiner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFileList;
        private System.Windows.Forms.Label lblBaseDirectory;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.RichTextBox txtUsings;
    }
}

