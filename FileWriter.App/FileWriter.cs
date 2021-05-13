using System;
using System.Threading.Tasks;
using System.IO;

namespace FileWriterEvents.App
{
    public class FileWriter
    {
        private readonly string _fileName;

        public string FileName {
            get { return _fileName; }
        }

        public FileWriter(string fileName, Publisher pub)
        {
            _fileName = fileName;

            // Subscribe to the event
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        // Define what actions to take when the event is raised.
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            System.IO.File.WriteAllText(@"./test.txt", $"Wrote PICKLE RICK to {_fileName}: {e.Message}");

            Console.WriteLine($"Wrote PICKLE RICK to {_fileName}: {e.Message}");
        }
    }
}
