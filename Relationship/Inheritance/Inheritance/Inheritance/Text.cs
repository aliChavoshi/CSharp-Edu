using System;

namespace Inheritance
{
    public class Text : PeresentaionObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("Added hyperlink" + url);
        }

    }
}
