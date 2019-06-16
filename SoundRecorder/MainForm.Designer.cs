namespace SoundRecorder
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
			this.OutputFileTextBox = new System.Windows.Forms.TextBox();
			this.SelectOutputFileButton = new System.Windows.Forms.Button();
			this.StartRecordingButton = new System.Windows.Forms.Button();
			this.StopRecordingButton = new System.Windows.Forms.Button();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.SettingsToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OutputFileTextBox
			// 
			this.OutputFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputFileTextBox.Location = new System.Drawing.Point(12, 28);
			this.OutputFileTextBox.Name = "OutputFileTextBox";
			this.OutputFileTextBox.ReadOnly = true;
			this.OutputFileTextBox.Size = new System.Drawing.Size(211, 20);
			this.OutputFileTextBox.TabIndex = 0;
			// 
			// SelectOutputFileButton
			// 
			this.SelectOutputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectOutputFileButton.Location = new System.Drawing.Point(229, 26);
			this.SelectOutputFileButton.Name = "SelectOutputFileButton";
			this.SelectOutputFileButton.Size = new System.Drawing.Size(42, 23);
			this.SelectOutputFileButton.TabIndex = 1;
			this.SelectOutputFileButton.Text = "...";
			this.SelectOutputFileButton.UseVisualStyleBackColor = true;
			this.SelectOutputFileButton.Click += new System.EventHandler(this.SelectOutputFileButton_Click);
			// 
			// StartRecordingButton
			// 
			this.StartRecordingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StartRecordingButton.Location = new System.Drawing.Point(12, 54);
			this.StartRecordingButton.Name = "StartRecordingButton";
			this.StartRecordingButton.Size = new System.Drawing.Size(259, 34);
			this.StartRecordingButton.TabIndex = 2;
			this.StartRecordingButton.Text = "Start Recording";
			this.StartRecordingButton.UseVisualStyleBackColor = true;
			this.StartRecordingButton.Click += new System.EventHandler(this.StartRecordingButton_Click);
			// 
			// StopRecordingButton
			// 
			this.StopRecordingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StopRecordingButton.Enabled = false;
			this.StopRecordingButton.Location = new System.Drawing.Point(12, 94);
			this.StopRecordingButton.Name = "StopRecordingButton";
			this.StopRecordingButton.Size = new System.Drawing.Size(259, 34);
			this.StopRecordingButton.TabIndex = 3;
			this.StopRecordingButton.Text = "Stop Recording";
			this.StopRecordingButton.UseVisualStyleBackColor = true;
			this.StopRecordingButton.Click += new System.EventHandler(this.StopRecordingButton_Click);
			// 
			// SaveFileDialog
			// 
			this.SaveFileDialog.DefaultExt = "mp3";
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(283, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// SettingsToolStripButton
			// 
			this.SettingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.SettingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsToolStripButton.Image")));
			this.SettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SettingsToolStripButton.Name = "SettingsToolStripButton";
			this.SettingsToolStripButton.Size = new System.Drawing.Size(53, 22);
			this.SettingsToolStripButton.Text = "Settings";
			this.SettingsToolStripButton.Click += new System.EventHandler(this.SettingsToolStripButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 140);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.StopRecordingButton);
			this.Controls.Add(this.StartRecordingButton);
			this.Controls.Add(this.SelectOutputFileButton);
			this.Controls.Add(this.OutputFileTextBox);
			this.Name = "MainForm";
			this.Text = "Sound Recorder";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox OutputFileTextBox;
		private System.Windows.Forms.Button SelectOutputFileButton;
		private System.Windows.Forms.Button StartRecordingButton;
		private System.Windows.Forms.Button StopRecordingButton;
		private System.Windows.Forms.SaveFileDialog SaveFileDialog;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton SettingsToolStripButton;
	}
}

