using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAndFileInfo
{
    public class PathClass
    {
        public void PathMethod()
        {
            var pathFileName1 = @"C:\Test\1\File1.txt";

            var dotindex = pathFileName1.IndexOf('.');
            var extension = pathFileName1.Substring(dotindex);

            Console.WriteLine("Extension Custom:" + extension);
            Console.WriteLine("Extension :" + Path.GetExtension(pathFileName1));
            Console.WriteLine("File Name :" + Path.GetFileName(pathFileName1));
            Console.WriteLine("GetFileNameWithoutExtension :" + Path.GetFileNameWithoutExtension(pathFileName1));
            Console.WriteLine("GetDirectoryName :" + Path.GetDirectoryName(pathFileName1));
            Console.WriteLine("GetFullPath :" + Path.GetFullPath(pathFileName1));
            Console.WriteLine("ChangeExtension :" + Path.ChangeExtension(pathFileName1, ".jpeg"));
            Console.WriteLine("GetPathRoot :" + Path.GetPathRoot(pathFileName1));
            Console.WriteLine("GetRandomFileName :" + Path.GetRandomFileName());
            Console.WriteLine("HasExtension :" + Path.HasExtension(pathFileName1));

        }
    }
}
