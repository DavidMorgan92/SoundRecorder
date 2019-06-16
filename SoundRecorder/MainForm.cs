using NAudio.Lame;
using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace SoundRecorder
{
	public partial class MainForm : Form
	{
		private WasapiLoopbackCapture capture;
		private Stream writer;

		private LAMEPreset mp3Quality;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			mp3Quality = Properties.Settings.Default.Mp3Quality;
		}

		private void StartRecordingButton_Click(object sender, System.EventArgs e)
		{
			capture = new WasapiLoopbackCapture();

			var extension = Path.GetExtension(OutputFileTextBox.Text);

			if (extension.Equals(".wav", StringComparison.CurrentCultureIgnoreCase))
			{
				writer = new WaveFileWriter(OutputFileTextBox.Text, capture.WaveFormat);
			}
			else if (extension.Equals(".mp3", StringComparison.CurrentCultureIgnoreCase))
			{
				writer = new LameMP3FileWriter(OutputFileTextBox.Text, capture.WaveFormat, mp3Quality);
			}
			else
			{
				MessageBox.Show("Only .wav and .mp3 extensions allowed");
				return;
			}

			capture.DataAvailable += (s, a) =>
			{
				writer.Write(a.Buffer, 0, a.BytesRecorded);
			};

			capture.RecordingStopped += (s, a) =>
			{
				writer.Dispose();
				writer = null;
				capture.Dispose();
			};

			capture.StartRecording();

			StartRecordingButton.Enabled = false;
			StopRecordingButton.Enabled = true;
		}

		private void StopRecordingButton_Click(object sender, System.EventArgs e)
		{
			capture.StopRecording();

			StartRecordingButton.Enabled = true;
			StopRecordingButton.Enabled = false;
		}

		private void SelectOutputFileButton_Click(object sender, EventArgs e)
		{
			if (SaveFileDialog.ShowDialog() == DialogResult.OK)
				OutputFileTextBox.Text = SaveFileDialog.FileName;
		}

		private void SettingsToolStripButton_Click(object sender, EventArgs e)
		{
			using (var dialog = new SettingsDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
					mp3Quality = dialog.Mp3Quality;
			}
		}
	}
}
