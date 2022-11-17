using NAudio.Lame;
using NAudio.Wave;
using System.Speech.Synthesis;

namespace Voicer.Components
{
    internal class AudioGenerator
    {
        /// <summary>
        /// Dispose the stream returned by this method after using.
        /// </summary>
        /// <param name="speechSynthesizer"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static MemoryStream GetAudioStream(SpeechSynthesizer speechSynthesizer, string text)
        {
            var streamAudio = new MemoryStream();

            speechSynthesizer.SetOutputToWaveStream(streamAudio);
            speechSynthesizer.Speak(text);
            speechSynthesizer.SetOutputToNull();

            return streamAudio;
        }

        public static void GenerateWAVFileAsync(SpeechSynthesizer speechSynthesizer, string text, string filePath)
        {
            if (Path.GetExtension(filePath) != ".wav")
                throw new ArgumentException("Invalid file extension!");

            Task.Run(() =>
            {
                var stream = GetAudioStream(speechSynthesizer, text);

                File.WriteAllBytes(filePath, stream.ToArray());

                stream.Dispose();
            });
        }

        public static void GenerateMP3FileAsync(SpeechSynthesizer speechSynthesizer, string text, string filePath)
        {
            if (Path.GetExtension(filePath) != ".mp3")
                throw new ArgumentException("Invalid file extension!");

            Task.Run(() =>
            {
                var stream = GetAudioStream(speechSynthesizer, text);
                stream.Position = 0;

                using var outputStream = new MemoryStream();
                using (var reader = new WaveFileReader(stream))
                using (var writer = new LameMP3FileWriter(outputStream, reader.WaveFormat, 128))
                {
                    reader.CopyTo(writer);
                }

                File.WriteAllBytes(filePath, outputStream.ToArray());

                stream.Dispose();
            });
        }
    }
}
