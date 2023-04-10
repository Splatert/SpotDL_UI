
namespace SpotDL_UI2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblText = new System.Windows.Forms.Label();
            this.tbDownload = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(50, 24);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(132, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Enter URL (Single/Album) ";
            // 
            // tbDownload
            // 
            this.tbDownload.Location = new System.Drawing.Point(12, 85);
            this.tbDownload.Name = "tbDownload";
            this.tbDownload.Size = new System.Drawing.Size(208, 35);
            this.tbDownload.TabIndex = 1;
            this.tbDownload.Text = "Download Track(s)";
            this.tbDownload.UseVisualStyleBackColor = true;
            this.tbDownload.Click += new System.EventHandler(this.tbDownload_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(12, 59);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(208, 20);
            this.tbURL.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 132);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.tbDownload);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotDL UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button tbDownload;
        private System.Windows.Forms.TextBox tbURL;
    }
}

