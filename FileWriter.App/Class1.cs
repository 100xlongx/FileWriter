using System;
using System.Threading.Tasks;
using System.IO;

namespace FileWriterEvents.App
{
    public class FileWriter
    {
        public FileWriter() {
            writeFile("PICKLERICK");
        }

        public void writeFile(string message) {
            File.WriteAllText("../test.txt", message);
        }
    }
}
