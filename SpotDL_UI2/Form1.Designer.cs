
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
            this.cbAutoDL = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(54, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(160, 32);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Enter URL (Single/Album)\r\nor Keywords";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDownload
            // 
            this.tbDownload.Location = new System.Drawing.Point(30, 103);
            this.tbDownload.Name = "tbDownload";
            this.tbDownload.Size = new System.Drawing.Size(208, 35);
            this.tbDownload.TabIndex = 1;
            this.tbDownload.Text = "Download Track(s)";
            this.tbDownload.UseVisualStyleBackColor = true;
            this.tbDownload.Click += new System.EventHandler(this.tbDownload_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(30, 77);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(208, 20);
            this.tbURL.TabIndex = 2;
            // 
            // cbAutoDL
            // 
            this.cbAutoDL.AutoSize = true;
            this.cbAutoDL.Location = new System.Drawing.Point(19, 54);
            this.cbAutoDL.Name = "cbAutoDL";
            this.cbAutoDL.Size = new System.Drawing.Size(230, 17);
            this.cbAutoDL.TabIndex = 3;
            this.cbAutoDL.Text = "Auto detect and download clipboard URLs.";
            this.cbAutoDL.UseVisualStyleBackColor = true;
            this.cbAutoDL.CheckedChanged += new System.EventHandler(this.cbAutoDL_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 150);
            this.Controls.Add(this.cbAutoDL);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.tbDownload);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotDL UI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button tbDownload;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.CheckBox cbAutoDL;
    }
}

