using System;
using System.Threading;

namespace StopWatch_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            Console.WriteLine("Enter Your CountRun :");
            var countRun = Console.ReadLine();

            Console.WriteLine("Please Enter Sleep :");
            var sleep = Console.ReadLine();

            stopWatch.Run(countRun: int.Parse(countRun), sleep: int.Parse(sleep));
        }
    }

    public interface IOptionWatch
    {
        DateTime StartTime();
        DateTime StopTime();
        TimeSpan GetInterval();
    }

    public class StopWatch : IOptionWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running;

        public DateTime StartTime()
        {
            if (_running)
                throw new InvalidOperationException("StopWatch in Running!");
            _startTime = DateTime.Now;
            _running = true;
            return _startTime;
        }

        public DateTime StopTime()
        {
            if (!_running)
            {
                throw new InvalidOperationException("StopWatch in Running!");
            }
            _stopTime = DateTime.Now;
            _running = false;
            return _stopTime;
        }

        public void Run(int countRun, int sleep)
        {
            for (int i = 0; i < countRun; i++)
            {
                Console.WriteLine("Date Now Start : " + " " + StartTime());

                Thread.Sleep(sleep);
                Console.WriteLine("Date Now Stop : " + " " + StopTime());

                Console.WriteLine("Diff :" + " " + GetInterval());
            }
        }

        public TimeSpan GetInterval()
        {
            return _stopTime - _startTime;
        }
    }
}
