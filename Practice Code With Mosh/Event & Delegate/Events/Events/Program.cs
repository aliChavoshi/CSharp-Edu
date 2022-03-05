using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class Video
    {
        public string Title { get; set; }
        public int Size { get; set; }
    }
    public class MessageService
    {
        //Same signature delegate
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("sending message :" + args.Video.Title);
        }
    }
    public class MailService
    {
        //Same signature delegate
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("sending message :" + args.Video.Title);
        }
    }
    public class VideoEncoder
    {
        //1- define a delegate
        //2- define an event base on that delegate
        //3- raise the event
        //public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Video Encoding :" + video.Title);
            Thread.Sleep(3000);
            //Call Event Indicator
            OnVideoEncoded(new VideoEventArgs() { Video = video });
        }
        protected virtual void OnVideoEncoded(VideoEventArgs e)
        {
            VideoEncoded?.Invoke(this, e);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(new Video() { Size = 10, Title = "video" });
        }
    }
}
