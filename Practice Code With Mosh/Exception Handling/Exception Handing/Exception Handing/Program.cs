using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Exception_Handing
{
    public class Claculator
    {
        public int Divide(int numerator, int denomentor) => numerator / denomentor;
    }

    public class Video
    {

    }

    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //logic
                //call catch
                throw new Exception("OOps");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new YouTubeException("very good", e);
            }
            return new List<Video>();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*#region ExapmpleDivide
            try
            {
                var calculate = new Claculator();
                var result = calculate.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("ArithmeticException ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error This Divide ");
                throw;
            }


            #endregion

            #region StreamReader

            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(path: @"c:\file.zip");
                var content = streamReader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }
            }

            #endregion

            #region Useing
            try
            {
                using (streamReader = new StreamReader(path: @"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            #endregion*/

            #region CustomException

            try
            {
                var api = new YouTubeApi();
                var vidoes = api.GetVideos("Ali");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            #endregion
        }
    }
}
