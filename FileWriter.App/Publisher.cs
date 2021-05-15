using System;

namespace FileWriter.App
{
    public class Publisher
    {
        // Declare the event using EventHandler<T>
        public event EventHandler<FileWriteComplete> RaiseCustomEvent;

        public void RaiseInsertMessageEvent(string message)
        {
            OnRaiseCustomEvent(new FileWriteComplete(message));
        }


        protected virtual void OnRaiseCustomEvent(FileWriteComplete e)
        {
            EventHandler<FileWriteComplete> raiseEvent = RaiseCustomEvent;

            if (raiseEvent == null) return;
            e.Message += $" at {DateTime.Now}";
            raiseEvent(this, e);
        }
    }
}