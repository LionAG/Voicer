using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Speech.Synthesis;
using Voicer.Components;

namespace Voicer.UserInterface
{
    public partial class MainWindow : BaseWindow
    {
        private SpeechSynthesizer SpeechSynthesizer { get; } = new SpeechSynthesizer();
        private bool IsSpeaking => SpeechSynthesizer.State.ToString().Equals("speaking", StringComparison.OrdinalIgnoreCase);
        private bool IsPaused => SpeechSynthesizer.State.ToString().Equals("paused", StringComparison.OrdinalIgnoreCase);
        private bool IsReady => SpeechSynthesizer.State.ToString().Equals("ready", StringComparison.OrdinalIgnoreCase);

        private HotKeyHandler ReadTextHotkey;
        private Configuration Configuration;

        public MainWindow()
        {
            InitializeComponent();

            ReadTextHotkey = new(this, Keys.S, 0x0002 | 0x4000);
            ReadTextHotkey.Register();

            Configuration = new();

            if (Configuration.LoadConfiguration() == false)
            {
                // No exisiting configuration was loaded.

                // Update voice, different OS may have different voices installed.
                Configuration.ConfigurationData.SynthesizerSettings.VoiceIdentifier = SpeechSynthesizer.Voice.Name;
            }
            else
            {
                SelectVoice(Configuration.ConfigurationData.SynthesizerSettings.VoiceIdentifier);
                SpeechSynthesizer.Volume = Configuration.ConfigurationData.SynthesizerSettings.Volume;
                SpeechSynthesizer.Rate = Configuration.ConfigurationData.SynthesizerSettings.Rate;
            }
        }

        // Hotkey message id
        private const int WM_HOTKEY_MSG_ID = 0x0312;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY_MSG_ID)
            {
                if (Configuration.ConfigurationData.ApplicationSettings.SayShortcutEnabled && Clipboard.ContainsText())
                {
                    richTextBox_InputText.Text = Clipboard.GetText();
                    BeginSpeaking();
                }
            }

            base.WndProc(ref m);
        }

        private void SelectVoice(string vcIdentifier)
        {
            var voice = SpeechSynthesizer.GetInstalledVoices()
                                         .Where(v => vcIdentifier.Contains(v.VoiceInfo.Name, StringComparison.OrdinalIgnoreCase))
                                         .First();

            SpeechSynthesizer.SelectVoice(voice.VoiceInfo.Name);
        }

        private void UpdateState()
        {
            label_SynthesizerState.Text = Enum.GetName(SpeechSynthesizer.State)?.ToUpperInvariant();
        }

        private void BeginSpeaking()
        {
            var textToSpeak = richTextBox_InputText.Text;

            if (string.IsNullOrEmpty(textToSpeak))
            {
                MessageBox.Show("Input text cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsPaused)
            {
                ResumeSpeaking();
            }

            SpeechSynthesizer.SpeakAsyncCancelAll();
            SpeechSynthesizer.SpeakAsync(richTextBox_InputText.Text);
        }

        private void PauseSpeaking()
        {
            if (IsSpeaking)
                SpeechSynthesizer.Pause();
        }

        private void ResumeSpeaking()
        {
            if (IsPaused)
                SpeechSynthesizer.Resume();
        }

        private void CancelSpeaking()
        {
            // If paused it needs to be resumed first.
            if (IsPaused)
                ResumeSpeaking();

            if (IsSpeaking)
                SpeechSynthesizer.SpeakAsyncCancelAll();
        }

        private void LoadText()
        {
            if (DialogResult.OK == openFileDialog_LoadFileSelection.ShowDialog())
            {
                richTextBox_InputText.Text = File.ReadAllText(openFileDialog_LoadFileSelection.FileName);
            }
        }

        private void ClearText()
        {
            richTextBox_InputText.Clear();
        }

        // TODO: Clean this, add another class "AudioGenerator" or something.
        private void GenerateAudio()
        {
            var text = richTextBox_InputText.Text;

            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Invalid input text!");
            }

            if (DialogResult.OK == MessageBox.Show("Select OK to generate audio!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
            {
                using (var synth = new SpeechSynthesizer())
                {
                    // Synchronize properties with the general synthesizer instance.

                    synth.Rate = SpeechSynthesizer.Rate;
                    synth.Volume = SpeechSynthesizer.Volume;
                    synth.SelectVoice(SpeechSynthesizer.Voice.Name);

                    // Begin operation.

                    var filePath = Path.Combine(Configuration.ConfigurationData.ApplicationSettings.AudioSaveLocation,
                                                $"{DateTime.Now:MM_d_yyyy_hh_mm_ss}");

                    switch (Configuration.ConfigurationData.ApplicationSettings.PreferredAudioFormat)
                    {
                        case AudioFormat.wav:
                            {
                                filePath += ".wav";

                                AudioGenerator.GenerateWAVFileAsync(synth, text, filePath);
                                break;
                            }
                        case AudioFormat.mp3:
                            {
                                filePath += ".mp3";

                                AudioGenerator.GenerateMP3FileAsync(synth, text, filePath);
                                break;
                            }
                    }

                    var result = MessageBox.Show($"Generating audio file {filePath} finished!\n\nSelect Yes to play the generated audio.\nSelect No to open the file directory.\nSelect Cancel to close.",
                                                 "Information",
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Asterisk);

                    if (result == DialogResult.Yes)
                        Process.Start("explorer", filePath);
                    else if (result == DialogResult.No)
                        Process.Start("explorer", Path.GetDirectoryName(filePath));
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            comboBox_VoiceSelection.Items.Clear();

            foreach (var voice in SpeechSynthesizer.GetInstalledVoices())
            {
                comboBox_VoiceSelection.Items.Add($"{voice.VoiceInfo.Name} [{voice.VoiceInfo.Culture}]");
            }

            comboBox_VoiceSelection.SelectedText = $"{SpeechSynthesizer.Voice.Name} [{SpeechSynthesizer.Voice.Culture}]";

            numericUpDown_SpeakingRate.Value = SpeechSynthesizer.Rate;
            numericUpDown_SpeakingVolume.Value = SpeechSynthesizer.Volume;
            label_Version.Text = $"Voicer v{Assembly.GetExecutingAssembly().GetName().Version?.ToString(3)}";

            SpeechSynthesizer.StateChanged += SpeechSynthesizer_StateChanged;
        }

        private void SpeechSynthesizer_StateChanged(object? sender, StateChangedEventArgs e)
        {
            UpdateState();
        }

        private void Button_Speak_Click(object sender, EventArgs e)
        {
            BeginSpeaking();
        }

        private void Button_Pause_Click(object sender, EventArgs e)
        {
            PauseSpeaking();
        }

        private void Button_Resume_Click(object sender, EventArgs e)
        {
            ResumeSpeaking();
        }

        private void ComboBox_VoiceSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = ((ComboBox)sender).Text;

            SelectVoice(value);
            Configuration.UpdateSynthesizerSettings("VoiceIdentifier", value);
        }

        private void NumericUpDown_SpeakingRate_ValueChanged(object sender, EventArgs e)
        {
            var value = Convert.ToInt32(((NumericUpDown)sender).Value);

            SpeechSynthesizer.Rate = value;
            Configuration.UpdateSynthesizerSettings("Rate", value);

        }

        private void NumericUpDown_SpeakingVolume_ValueChanged(object sender, EventArgs e)
        {
            var value = Convert.ToInt32(((NumericUpDown)sender).Value);

            SpeechSynthesizer.Volume = value;
            Configuration.UpdateSynthesizerSettings("Volume", value);
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            CancelSpeaking();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadText();
        }

        private void SaveToWAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateAudio();
        }

        private void ClearCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsWindow(Configuration).ShowDialog();
        }
    }
}