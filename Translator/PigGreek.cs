using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    //The pigGreek and the PigLatin are both the same class except of what is added to the end of each word. Other then that the classes are identical.
    class PigGreek : ITranslator
    {
        //variables for the pigGreek translator.
        string originalText;
        string firstLetter;
        string vowelList = "aeiouAEIOU";
        string numList = "123456789";
        string oi = "oi ";
        string omatos = "omatos ";
        int vowel;
        string restOfWord;
        int symbolNumbers;
        string translated;

        //the part of the class that is from the interface.
        public string Translate(string wordsEntered)
        {
            translated = " ";
            originalText = wordsEntered;

            foreach (string words in originalText.Split(' '))
            {
                if (words == "")
                {
                    translated += words;
                }
                else
                {
                    firstLetter = words.Substring(0, 1);
                    restOfWord = words.Substring(1, words.Length - 1);
                    vowel = vowelList.IndexOf(firstLetter);
                    symbolNumbers = numList.IndexOf(firstLetter);

                    if (restOfWord.Contains('.') | restOfWord.Contains('!') | restOfWord.Contains('?') && !restOfWord.Contains('@'))
                    {
                        PunctuatedWord(restOfWord);

                    }
                    else if (restOfWord.Contains("@"))
                    {
                        translated += words + " ";
                    }
                    else
                    {
                        if (vowel == -1 && symbolNumbers == -1)
                        {
                            translated += restOfWord + firstLetter + oi;
                        }
                        else if (vowel != -1 && symbolNumbers == -1)
                        {
                            translated += words + omatos;
                        }
                        else if (symbolNumbers != -1)
                        {
                            translated += words + " ";
                        }
                    }
                }
               

            }

            return translated;

        }

        //this is a function I created to keep the above code neat.
        //the code will go through the word and depending on the punctuation will do the same as above except it will put the punctuation at the end
        //where it started. This does it for .!?.
        public string PunctuatedWord(string word)
        {
            if (word.Contains('.'))
            {
                if (vowel == -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);

                    translated += newword + firstLetter + "oi. ";
                }
                else if (vowel != -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword + "omatos. ";
                }
                else if (symbolNumbers != -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword + ".";
                }
            }
            if (word.Contains('!'))
            {
                if (vowel == -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);

                    translated += newword + firstLetter + "oi! ";
                }
                else if (vowel != -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword + "omatos! ";
                }
                else if (symbolNumbers != -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword + "!";
                }
            }
            if (word.Contains('?'))
            {
                if (vowel == -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);

                    translated += newword + firstLetter + "oi? ";
                }
                else if (vowel != -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword +"omatos? ";
                }
                else if (symbolNumbers != -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword + "?";
                }
            }

            return translated;
        }

        //code that takes the punctuation off the end. 
        public string PunctuationCorrection(string word)
        {
            //creates a new string that I can work with.
            StringBuilder punctuationString = new StringBuilder();

            //for each loop that loops through the word and if the char isnt a punctuation it adds it to the word
            //if it is a punctuation it skips it.
            foreach (char x in word)
            {
                if (!char.IsPunctuation(x))
                    punctuationString.Append(x);
            }
            //returns the new string without punctuation.
            return punctuationString.ToString();
        }



    }
}
