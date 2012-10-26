
namespace TestArgbColorDialog
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.colorDialogButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// colorDialogButton
			// 
			this.colorDialogButton.Location = new System.Drawing.Point(56, 48);
			this.colorDialogButton.Name = "colorDialogButton";
			this.colorDialogButton.Size = new System.Drawing.Size(182, 133);
			this.colorDialogButton.TabIndex = 0;
			this.colorDialogButton.Text = "Color Dialog";
			this.colorDialogButton.UseVisualStyleBackColor = true;
			this.colorDialogButton.Click += new System.EventHandler(this.ColorDialogButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.colorDialogButton);
			this.Name = "MainForm";
			this.Text = "TestArgbColorDialog";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button colorDialogButton;
	}
}
