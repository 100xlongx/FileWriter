using System;

namespace FileWriter.App
{
    public class FileWriteComplete : EventArgs
    {
        public string Message { get; set; }
        public FileWriteComplete(string message)
        {
            Message = message;
        }

   
    }
}