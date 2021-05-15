using System;

namespace FileWriter.App
{
    public class FileWriteComplete : EventArgs
    {
        public FileWriteComplete(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}