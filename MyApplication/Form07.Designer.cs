
namespace MyApplication
{
	partial class Form07
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
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.myLabel.Location = new System.Drawing.Point(12, 9);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(150, 34);
            this.myLabel.TabIndex = 0;
            this.myLabel.Text = "Hello this is my label\r\n-sepehr golpazir\r\n";
            // 
            // Form07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.myLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form07";
            this.Text = "Sepehr\'s Form";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion /Windows Form Designer generated code

        private System.Windows.Forms.Label myLabel;
    }
}
