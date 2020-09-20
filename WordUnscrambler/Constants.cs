using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WordUnscrambler
{
    class Constants
    {
        
        public string initialMessage = "Enter scrambled word(s) manually or as a file: F - file / M - manual";

        public string enterFilePath = "Enter file path including file name: ";

        public string manualEntry = "Enter word(s) manually separated by commas: ";

        public string firstEntryError = "Entered option was not recognized.";

        public string continueChoiceMessage = "Would you like to continue? Y / N";

        public string errorMessage = "An unexpected error has occured, please restart your program.";

        public string matchFound = "MATCH FOUND FOR ";

        public string matchNotFound = "NO MATCHES FOUND FOR ";

        public string wordListFile = "wordlist.txt";


    }
}
