using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAndFileInfo
{
    public class DirectoryInfoClass
    {
        public void DirectoryInfoMethod()
        {
            var pathFileName1 = @"C:\Test\1\File1.txt";
            var pathFileName2 = @"C:\Test\2\test.txt";
            var path1 = @"C:\Test";
            var path2 = @"C:\Test\2";


            //Directory Info
            var directoryInfo = new DirectoryInfo(path1);
            var filesDir = directoryInfo.GetFiles();
            var dir = directoryInfo.GetDirectories();
        }
    }
}
