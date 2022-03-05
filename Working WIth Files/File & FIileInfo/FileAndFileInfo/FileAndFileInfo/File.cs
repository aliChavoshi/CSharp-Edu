using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAndFileInfo
{
    public class FileClass
    {
        public void FileMethod()
        {
            var pathFileName1 = @"C:\Test\1\File1.txt";
            var pathFileName2 = @"C:\Test\2\test.txt";
            var path1 = @"C:\Test";
            var path2 = @"C:\Test\2";
            Console.WriteLine(Directory.GetCurrentDirectory());
            File.Copy(sourceFileName: pathFileName1, destFileName: pathFileName2, overwrite: true);
            File.Delete(pathFileName1);

            if (File.Exists(pathFileName1))
            {
                Console.WriteLine("ok");
            }

            var content = File.ReadAllText(pathFileName1);
            Console.WriteLine(content);
        }
    }
}
