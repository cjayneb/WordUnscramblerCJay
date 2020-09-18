using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();

            foreach(string scrambledWord in scrambledWords)
            {
                foreach(string word in wordList)
                {
                    //scrambledWord already matches word
                    if(scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuilMatchedWord(scrambledWord, word));
                    }
                    else
                    {
                        //convert the strings into character arrays
                        char[] scrambledWordChar = scrambledWord.ToCharArray();
                        char[] wordChar = word.ToCharArray();


                        //sort both character arrays (Array.Sort())
                        //act -> sort -> act
                        //cat -> sort -> act

                        //convert arrays back to a string

                        //compare the two strings
                        //if equal, add to List
                    }
                }
            }


            MatchedWord BuilMatchedWord(string scrambledWord, string word)
            {
                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWord = scrambledWord,
                    Word = word
                };

                return matchedWord;
            }


            return matchedWords;
        }
    }
}
