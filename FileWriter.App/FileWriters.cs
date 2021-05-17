using System;
using System.IO;

namespace FileWriter.App
{
    public class FileWriters
    {
        public readonly string FileName;

        public FileWriters(string fileName, Publisher pub)
        {
            FileName = fileName;

            // Subscribe to the event
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        private void HandleCustomEvent(object sender, FileWriteComplete e)
        {
            File.AppendAllText($"../../../../{FileName}.txt",
                $"Wrote PICKLE RICK to {FileName}: {e.Message}\n");

            Console.WriteLine($"Wrote PICKLE RICK to {FileName}: {e.Message}");
        }
    }
}