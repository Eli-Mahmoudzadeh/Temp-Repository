namespace MyApplication
{
	partial class Form01
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

		#region Windows Form Designer generated code:
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.NameLabel.Location = new System.Drawing.Point(38, 170);
            this.NameLabel.Name = "nameLabel";
            this.NameLabel.Size = new System.Drawing.Size(393, 18);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Elnaz Mahmoudzadeh has made some changes";
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.NameLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form01";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion /Windows Form Designer generated code

        private System.Windows.Forms.Label NameLabel;
    }
}
