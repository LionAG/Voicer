using Voicer.Components;

namespace Voicer.UserInterface
{
    public partial class SettingsWindow : BaseWindow
    {
        private readonly Configuration Configuration;

        public SettingsWindow(Configuration configuration)
        {
            InitializeComponent();

            Configuration = configuration;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            var appSettings = Configuration.ConfigurationData.ApplicationSettings;

            checkBox_EnableSayShortcut.Checked = appSettings.SayShortcutEnabled;

            comboBox_AudioFormatSelection.Items.Clear();
            comboBox_AudioFormatSelection.Items.AddRange(Enum.GetNames<AudioFormat>());
            comboBox_AudioFormatSelection.SelectedText = Enum.GetName(appSettings.PreferredAudioFormat);
        }

        private void CheckBox_EnableSayShortcut_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.UpdateApplicationSettings("SayShortcutEnabled", ((CheckBox)sender).Checked);
        }

        private void ComboBox_AudioFormatSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            var format = AudioFormat.wav;

            switch (((ComboBox)sender).SelectedItem)
            {
                case "wav":
                    {
                        format = AudioFormat.wav;
                        break;
                    }
                case "mp3":
                    {
                        format = AudioFormat.mp3;
                        break;
                    }
            }

            Configuration.UpdateApplicationSettings("PreferredAudioFormat", format);
        }

        private void Button_SelectLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Configuration.UpdateApplicationSettings("AudioSaveLocation", folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
