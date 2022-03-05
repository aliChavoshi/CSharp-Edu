using System;

namespace Exception_Handing
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}