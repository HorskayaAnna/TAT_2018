using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Task3
{
    class FileFinder
    {
        string extension;
        string folderName;

        public FileFinder(string paramExtension,string paramFalderName)
        {
            extension = paramExtension;
            folderName = paramFalderName;
        }

        public string[] GetFilesByExtension()
        {
            return System.IO.Directory.GetFiles(folderName, "*." + extension, SearchOption.AllDirectories);
        }

    }
}
