using System;
using System.Net.Http.Headers;

namespace Deleagtes
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo) => Console.WriteLine("ApplyBrightness");
        public void ApplyContrast(Photo photo) => Console.WriteLine("ApplyContrast");
        public void Resize(Photo photo) => Console.WriteLine("Resize");
    }

    public class Photo
    {
        //No instance
        public static Photo Load(string path)
        {
            return new Photo();
        }
        public void Save()
        {
            //save photo
        }
    }

    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> filterHandler)
        {
            //return New Photo
            var photo = Photo.Load(path);

            //out void
            //in Photo
            filterHandler(photo);

            photo.Save();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //new photo and load
            var process = new PhotoProcessor();

            var filters = new PhotoFilters();

            //out void
            //in Photo
            //Same Signature
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            //give me path
            //give me delegate
            process.Process("path", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("RemoveRedEyeFilter");
        }
    }


}
