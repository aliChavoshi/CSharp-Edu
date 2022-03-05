using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Text;

namespace FileAndFileInfo
{
    public class DirectoryClass
    {
        public void DirectoryMethod()
        {
            var pathFileName1 = @"C:\Test\1\File1.txt";
            var pathFileName2 = @"C:\Test\2\test.txt";
            var path1 = @"C:\Test";
            var path2 = @"C:\Test\2";



            //Directory
            if (Directory.Exists(path1))
            {
                Console.WriteLine("Ok Path");
                //Directory.CreateDirectory(path);
            }

            var files = Directory.GetFiles(path1, "*.*", searchOption: SearchOption.AllDirectories);
            var filesTxt = Directory.GetFiles(path2, "*.txt", searchOption: SearchOption.AllDirectories);

            foreach (var file in files)
                Console.WriteLine(file);

            //Get Directory
            var directories = Directory.GetDirectories(path1, "*.*", SearchOption.AllDirectories);
            foreach (var direcory in directories)
                Console.WriteLine(direcory);
        }
    }
}
