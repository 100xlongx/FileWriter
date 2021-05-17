using System;
using System.IO;

namespace FileWriter.App
{
    public class FileWriters
    {
        // Declare the event using EventHandler<T>
        public event EventHandler<FileWriteComplete> RaiseCustomEvent;

        public void RaiseInsertMessageEvent(string message,string fileName)
        {
            OnRaiseCustomEvent(new FileWriteComplete(message), fileName);
        }


        protected virtual void OnRaiseCustomEvent(FileWriteComplete e, string fileName)
        {
            EventHandler<FileWriteComplete> raiseEvent = RaiseCustomEvent;

            if (raiseEvent == null) return;
            
            e.Message += $" at {DateTime.Now}";
            
            File.AppendAllText($"../../../../{fileName}.txt",
                $"Wrote PICKLE RICK to {fileName}: {e.Message}\n");
            
            Console.WriteLine($"Wrote PICKLE RICK to {fileName}: {e.Message}");
            raiseEvent(this, e);
        }
    }
}