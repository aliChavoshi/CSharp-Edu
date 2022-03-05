using System;

namespace Interfaces_and_Polymorphism
{

    class Program
    {
        static void Main(string[] args)
        {
            var videoEncode = new VideoEncoder();
            videoEncode.RegisterNotificationChannel(new MailNotificationChannel());
            videoEncode.RegisterNotificationChannel(new SmsNotifiactionChanned());
            videoEncode.Encode(new Video());
        }
    }
}
