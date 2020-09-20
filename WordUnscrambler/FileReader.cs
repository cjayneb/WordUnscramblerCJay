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
        public static Constants constants = new Constants();

        public string[] Read(string filename)
        {

            //declare a string[] to hold the content of the file
            string[] content = null;


                 //try/catch
            try
            {
                //read from the file - ReadAllLines()
                content = File.ReadAllLines(filename);

            }
            catch(Exception ex)
            {
              Console.WriteLine(constants.errorMessage + ex.Message);
            }


            return content;


        }

    }
}
