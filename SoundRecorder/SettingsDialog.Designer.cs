namespace SoundRecorder
{
	partial class SettingsDialog
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
			this._CancelButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Mp3QualityComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// _CancelButton
			// 
			this._CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._CancelButton.Location = new System.Drawing.Point(261, 109);
			this._CancelButton.Name = "_CancelButton";
			this._CancelButton.Size = new System.Drawing.Size(75, 23);
			this._CancelButton.TabIndex = 2;
			this._CancelButton.Text = "Cancel";
			this._CancelButton.UseVisualStyleBackColor = true;
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Location = new System.Drawing.Point(180, 109);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 1;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "MP3 Quality";
			// 
			// Mp3QualityComboBox
			// 
			this.Mp3QualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Mp3QualityComboBox.FormattingEnabled = true;
			this.Mp3QualityComboBox.Location = new System.Drawing.Point(135, 12);
			this.Mp3QualityComboBox.Name = "Mp3QualityComboBox";
			this.Mp3QualityComboBox.Size = new System.Drawing.Size(201, 21);
			this.Mp3QualityComboBox.TabIndex = 0;
			// 
			// SettingsDialog
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._CancelButton;
			this.ClientSize = new System.Drawing.Size(348, 144);
			this.Controls.Add(this.Mp3QualityComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this._CancelButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _CancelButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Mp3QualityComboBox;
	}
}