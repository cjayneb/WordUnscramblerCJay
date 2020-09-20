 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WordUnscrambler
{
    class Program
    {

        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        public static  Constants constants = new Constants();
        

        static void Main(string[] args)
        {
            
            try
            {
                string finalAnswer = null;
                do
                {
                    Console.WriteLine(constants.InitialMessage);
                    string option = Console.ReadLine();

                    while (option.ToUpper() != "F" & option.ToUpper() != "M")
                    {
                        Console.WriteLine("Enter scrambled word(s) manually or as a file: F - file / M - manual");
                        option = Console.ReadLine();
                    }

                    switch (option.ToUpper())
                    {
                        case "F":
                            Console.Write("Enter file path including file name: ");
                            //do something
                            ExecuteScrambledWordsInFileScenario();
                            break;
                        case "M":
                            Console.Write("Enter word(s) manually separated by commas: ");
                            //do something
                            ExecuteScrambledWordsManualEntryScenario();
                            break;
                        default:
                            Console.WriteLine("Entered option was not recognized.");
                            break;
                            //this default case will never execute since we have the while loop making sure the first entry is an 'm' or an 'f'
                    }

                    do
                    {
                        Console.WriteLine(constants.ConinueChoiceMessage);
                        finalAnswer = Console.ReadLine();
                    } while (finalAnswer.ToUpper() != "N" & finalAnswer.ToUpper() != "Y");
                    
                } while (finalAnswer.ToUpper().Equals("Y"));


            } catch(Exception ex)
            {
                Console.WriteLine("The program ran into an error: " + ex.Message);
            }
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            string manualInput = Console.ReadLine();

            char[] separators = {',', ' '};

            string[] scrambledWords = manualInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            try
            {
                string filename = Console.ReadLine();

                //read words from file and store in string[] scrambleWords
                string[] scrambledWords = _fileReader.Read(filename);

                //display the matched words
                DisplayMatchedUnscrambledWords(scrambledWords);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The program ran into an error: " + ex.Message);
            }
        }

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words in the wordlist.txt file
            string[] wordList = _fileReader.Read("wordlist.txt");

            //call a word matcher method, to get a list of MatchedWords structs
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            //display the matches

            if (matchedWords.Any())
            {
                //loop through List and print to console the contents of the structs
                //foreach
                foreach(var matchedWord in matchedWords)
                {
                    //MATCH FOUND FOR act: cat
                    Console.WriteLine("MATCH FOUND FOR " + matchedWord.ScrambledWord + ": " + matchedWord.Word);
                }

            }
            else
            {
                Console.WriteLine("NO MATCHES HAVE BEEN FOUND");
            }
        }
    }
}
