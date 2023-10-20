using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMAtoMP3_UI
{
    using System;
    using NAudio.Wave;
    using System.IO;
    using NAudio.Lame;
    internal class Convertor
    {
        public string Input, Output;
        public long Size;
        public Convertor(string input, string output)
        {
            Input = input;
            Output = output;
        }
        public void Run()
        {
            string inputFolder = Input;
            string outputFolder = Output;

            ConvertWmaToMp3(Input, Output);
        }

        static void ConvertWmaToMp3(string inputFolder, string outputFolder)
        {
            Directory.CreateDirectory(outputFolder);

            foreach (string wmaFilePath in Directory.GetFiles(inputFolder, "*.wma", SearchOption.AllDirectories))
            {
                string outputFilePath = Path.Combine(outputFolder, Path.ChangeExtension(Path.GetFileName(wmaFilePath), ".mp3"));

                using (var reader = new MediaFoundationReader(wmaFilePath))
                using (var writer = new LameMP3FileWriter(outputFilePath, reader.WaveFormat, 128))
                {
                    reader.CopyTo(writer);
                }

                Console.WriteLine($"Converted: {wmaFilePath} -> {outputFilePath}");
            }
        }

      
    }
}
