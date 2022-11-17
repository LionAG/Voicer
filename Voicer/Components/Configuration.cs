using System.Reflection;
using System.Xml.Serialization;

namespace Voicer.Components
{
    public enum AudioFormat
    {
        wav,
        mp3
    }

    [Serializable]
    public class ApplicationSettings
    {
        public AudioFormat PreferredAudioFormat { get; set; } = AudioFormat.wav;
        public string AudioSaveLocation { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public bool SayShortcutEnabled { get; set; } = true;
    }

    [Serializable]
    public class SynthesizerSettings
    {
        public string VoiceIdentifier { get; set; } = "Sam";
        public int Volume { get; set; } = 100;
        public int Rate { get; set; } = 0;
    }

    [Serializable]
    public class ApplicationConfiguration
    {
        public ApplicationSettings ApplicationSettings { get; set; } = new();
        public SynthesizerSettings SynthesizerSettings { get; set; } = new();
    }


    public class Configuration
    {
        public ApplicationConfiguration ConfigurationData { get; private set; } = new();

        public static string ConfigurationDirectory
        {
            get
            {
                var assemblyName = Path.GetFileName(Assembly.GetExecutingAssembly().GetName().Name);
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), assemblyName);

                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }

                return path;
            }
        }

        public static string ConfigurationFile => Path.Combine(ConfigurationDirectory, "Configuration.xml");

        public bool LoadConfiguration()
        {
            if (File.Exists(ConfigurationFile) == false)
                return false;

            using (var reader = new StreamReader(ConfigurationFile))
            {
                var serializer = new XmlSerializer(typeof(ApplicationConfiguration));
                var data = serializer.Deserialize(reader);

                if (data != null)
                {
                    ConfigurationData = (ApplicationConfiguration)data;
                    return true;
                }
            }

            return false;
        }

        public bool SaveConfiguration()
        {
            if (Directory.Exists(ConfigurationDirectory) == false)
                return false;

            using (var writer = new StreamWriter(ConfigurationFile))
            {
                var serializer = new XmlSerializer(typeof(ApplicationConfiguration));
                serializer.Serialize(writer, ConfigurationData);
            }

            return true;
        }

        public bool UpdateApplicationSettings(string paramName, object value)
        {
            var prop = typeof(ApplicationSettings).GetProperty(paramName);

            if (prop == null)
            {
                throw new ArgumentException($"Invalid property name! [{paramName}]");
            }

            prop.SetValue(ConfigurationData.ApplicationSettings, value);

            return SaveConfiguration();
        }

        public bool UpdateSynthesizerSettings(string paramName, object value)
        {
            var prop = typeof(SynthesizerSettings).GetProperty(paramName);

            if (prop == null)
            {
                throw new ArgumentException($"Invalid property name! [{paramName}]");
            }

            prop.SetValue(ConfigurationData.SynthesizerSettings, value);

            return SaveConfiguration();
        }
    }
}
