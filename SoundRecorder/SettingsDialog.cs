using NAudio.Lame;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SoundRecorder
{
	public partial class SettingsDialog : Form
	{
		private class Mp3QualityComboBoxItem
		{
			public string Text { get; set; }

			public LAMEPreset Value { get; set; }

			public override string ToString()
			{
				return Text;
			}
		}

		private readonly Mp3QualityComboBoxItem[] Mp3QualityOptions = new Mp3QualityComboBoxItem[] {
			new Mp3QualityComboBoxItem { Text = "ABR 8", Value = LAMEPreset.ABR_8 },
			new Mp3QualityComboBoxItem { Text = "ABR 16", Value = LAMEPreset.ABR_16 },
			new Mp3QualityComboBoxItem { Text = "ABR 32", Value = LAMEPreset.ABR_32 },
			new Mp3QualityComboBoxItem { Text = "ABR 48", Value = LAMEPreset.ABR_48 },
			new Mp3QualityComboBoxItem { Text = "ABR 64", Value = LAMEPreset.ABR_64 },
			new Mp3QualityComboBoxItem { Text = "ABR 96", Value = LAMEPreset.ABR_96 },
			new Mp3QualityComboBoxItem { Text = "ABR 128", Value = LAMEPreset.ABR_128 },
			new Mp3QualityComboBoxItem { Text = "ABR 160", Value = LAMEPreset.ABR_160 },
			new Mp3QualityComboBoxItem { Text = "ABR 256", Value = LAMEPreset.ABR_256 },
			new Mp3QualityComboBoxItem { Text = "ABR 320", Value = LAMEPreset.ABR_320 },
			new Mp3QualityComboBoxItem { Text = "VBR 10", Value = LAMEPreset.VBR_10 },
			new Mp3QualityComboBoxItem { Text = "VBR 20", Value = LAMEPreset.VBR_20 },
			new Mp3QualityComboBoxItem { Text = "VBR 30", Value = LAMEPreset.VBR_30 },
			new Mp3QualityComboBoxItem { Text = "VBR 40", Value = LAMEPreset.VBR_40 },
			new Mp3QualityComboBoxItem { Text = "VBR 50", Value = LAMEPreset.VBR_50 },
			new Mp3QualityComboBoxItem { Text = "VBR 60", Value = LAMEPreset.VBR_60 },
			new Mp3QualityComboBoxItem { Text = "VBR 70", Value = LAMEPreset.VBR_70 },
			new Mp3QualityComboBoxItem { Text = "VBR 80", Value = LAMEPreset.VBR_80 },
			new Mp3QualityComboBoxItem { Text = "VBR 90", Value = LAMEPreset.VBR_90 },
			new Mp3QualityComboBoxItem { Text = "VBR 100", Value = LAMEPreset.VBR_100 },
			new Mp3QualityComboBoxItem { Text = "Standard", Value = LAMEPreset.STANDARD },
			new Mp3QualityComboBoxItem { Text = "Standard Fast", Value = LAMEPreset.STANDARD_FAST },
			new Mp3QualityComboBoxItem { Text = "Medium", Value = LAMEPreset.MEDIUM },
			new Mp3QualityComboBoxItem { Text = "Medium Fast", Value = LAMEPreset.MEDIUM_FAST },
			new Mp3QualityComboBoxItem { Text = "Extreme", Value = LAMEPreset.EXTREME },
			new Mp3QualityComboBoxItem { Text = "Extreme Fast", Value = LAMEPreset.EXTREME_FAST },
			new Mp3QualityComboBoxItem { Text = "Insane", Value = LAMEPreset.INSANE },
			new Mp3QualityComboBoxItem { Text = "R3mix", Value = LAMEPreset.R3MIX }
		};

		public LAMEPreset Mp3Quality { get; set; }

		public SettingsDialog()
		{
			InitializeComponent();
		}

		private void SettingsDialog_Load(object sender, EventArgs e)
		{
			// Populate MP3 Quality Combo Box with items
			Mp3QualityComboBox.Items.AddRange(Mp3QualityOptions);

			// Throw if the chosen MP3 Quality from the settings file is out of range
			var selectedIndex = Mp3QualityOptions.ToList().FindIndex(item => item.Value == Properties.Settings.Default.Mp3Quality);
			if (selectedIndex < 0 || selectedIndex >= Mp3QualityOptions.Length)
				throw new Exception("Invalid MP3 quality setting");

			// Select the chosen MP3 Quality from the settings file
			Mp3QualityComboBox.SelectedIndex = selectedIndex;
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			Mp3Quality = Mp3QualityOptions[Mp3QualityComboBox.SelectedIndex].Value;

			Properties.Settings.Default.Mp3Quality = Mp3Quality;
			Properties.Settings.Default.Save();
		}
	}
}
