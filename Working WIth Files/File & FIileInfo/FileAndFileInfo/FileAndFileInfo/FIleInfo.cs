using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAndFileInfo
{
    public class FIleInfoClass
    {
        public void FileInfoMehtod()
        {
            var pathFileName1 = @"C:\Test\1\File1.txt";
            var pathFileName2 = @"C:\Test\2\test.txt";
            var path1 = @"C:\Test";
            var path2 = @"C:\Test\2";

            var fileInfo = new FileInfo(pathFileName1);
            fileInfo.CopyTo(pathFileName2);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                Console.WriteLine("Ok File1");
            }
        }
    }
}
