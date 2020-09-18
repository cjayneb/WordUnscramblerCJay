using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            //declare a string[] to hold the content of the file
            string[] content = File.ReadAllLines(filename);
            //try/catch
            //read from the file - ReadAllLines()


            return content;
        }
    }
}
