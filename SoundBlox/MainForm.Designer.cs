namespace SoundBlox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FEXSOUNDS = new System.Windows.Forms.WebBrowser();
            this.BUILTINSOUNDS = new System.Windows.Forms.WebBrowser();
            this.transfersounds = new System.Windows.Forms.Button();
            this.guidelabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FEXSOUNDS
            // 
            this.FEXSOUNDS.Location = new System.Drawing.Point(478, 44);
            this.FEXSOUNDS.MinimumSize = new System.Drawing.Size(20, 20);
            this.FEXSOUNDS.Name = "FEXSOUNDS";
            this.FEXSOUNDS.Size = new System.Drawing.Size(283, 366);
            this.FEXSOUNDS.TabIndex = 0;
            // 
            // BUILTINSOUNDS
            // 
            this.BUILTINSOUNDS.Location = new System.Drawing.Point(12, 44);
            this.BUILTINSOUNDS.MinimumSize = new System.Drawing.Size(20, 20);
            this.BUILTINSOUNDS.Name = "BUILTINSOUNDS";
            this.BUILTINSOUNDS.Size = new System.Drawing.Size(283, 366);
            this.BUILTINSOUNDS.TabIndex = 1;
            // 
            // transfersounds
            // 
            this.transfersounds.Location = new System.Drawing.Point(301, 194);
            this.transfersounds.Name = "transfersounds";
            this.transfersounds.Size = new System.Drawing.Size(171, 23);
            this.transfersounds.TabIndex = 2;
            this.transfersounds.Text = "Transfer Sounds";
            this.transfersounds.UseVisualStyleBackColor = true;
            this.transfersounds.Click += new System.EventHandler(this.transfersounds_Click);
            // 
            // guidelabel1
            // 
            this.guidelabel1.AutoSize = true;
            this.guidelabel1.Location = new System.Drawing.Point(103, 28);
            this.guidelabel1.Name = "guidelabel1";
            this.guidelabel1.Size = new System.Drawing.Size(89, 13);
            this.guidelabel1.TabIndex = 3;
            this.guidelabel1.Text = "Sounds Available";
            this.guidelabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sounds in roblox.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert Media";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Credits";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guidelabel1);
            this.Controls.Add(this.transfersounds);
            this.Controls.Add(this.BUILTINSOUNDS);
            this.Controls.Add(this.FEXSOUNDS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SoundBlox :: Replace Roblox Sounds";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser FEXSOUNDS;
        private System.Windows.Forms.WebBrowser BUILTINSOUNDS;
        private System.Windows.Forms.Button transfersounds;
        private System.Windows.Forms.Label guidelabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

