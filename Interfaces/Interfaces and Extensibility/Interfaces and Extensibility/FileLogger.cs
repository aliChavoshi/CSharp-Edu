using System.IO;

namespace Interfaces_and_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "LOGINFO");
        }

        private void Log(string message, string messageType)
        {
            //for dispose
            using var streamWriter = new StreamReader(path: path, false);
            streamWriter.ReadLine();
            streamWriter.Dispose();
        }
    }
}
