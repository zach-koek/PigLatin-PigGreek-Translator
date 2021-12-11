using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class PigLatin : ITranslator
    {
        //all the variables for the piglatin class.
        string originalText;
        string firstLetter;
        string vowelList = "aeiouAEIOU";
        string numList = "123456789";
        string restOfWord;
        string way = "way ";
        string ay = "ay ";
        int vowel;
        int symbolNumbers;
        string translated;

        //the part of the class that is from the interface.
        public string Translate(string wordsEntered)
        {
            //initiates a variable and sets the input word to a variable.
            translated = " ";
            originalText = wordsEntered;

            //foreach loop to go through each word as its split with a space.
            foreach (string words in originalText.Split(' '))
             {
                //this stops the program from trying to split a space. If this isnt here if there is 2 spaces it will throw an exception.
                if (words == "")
                {
                    //justs puts the word back where it was without doing anything.
                    translated += words;
                }
                else
                {
                    //variables that are getting instintiated.
                    //gets the first letter
                    firstLetter =  words.Substring(0, 1);
                    //gets the rest of the word except the first letter
                    restOfWord = words.Substring(1, words.Length - 1);
                    //checks to see if a vowel is the first letter
                    vowel = vowelList.IndexOf(firstLetter);
                    //checks to see if a number is the first letter. 
                    symbolNumbers = numList.IndexOf(firstLetter);

                    //if the word contains punctuation. 
                    if (restOfWord.Contains('.') | restOfWord.Contains('!') | restOfWord.Contains('?') && !restOfWord.Contains("@"))
                    {
                        //sends the rest of the word to a function that strips the punctuation off.
                        PunctuatedWord(restOfWord);

                    }
                    //checks for the @ sign and doesnt do anything to those words either. 
                    else if (restOfWord.Contains("@"))
                    {
                        translated += words + " ";
                    }
                    //this is the rest of the program that actually messes with the words.
                    else
                    {
                        //if it is a word with a consenant in front then it will add ay to the end after putting the first letter on the end. 
                        if (vowel == -1 && symbolNumbers == -1)
                        {
                            translated += restOfWord + firstLetter + ay;
                        }
                       //if the word starts with a vowel then it just adds way.
                        else if (vowel != -1 && symbolNumbers == -1)
                        {
                            translated += words + way;
                        }
                        //if the word is a number then it just adds it as well.
                        else if (symbolNumbers != -1)
                        {
                            translated += words + " ";
                        }
                    }
                }

             }
            //the final string that will be sent to the textbox. 
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

                    translated += newword + firstLetter + "ay. ";
                }
                else if (vowel != -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword + "way. ";
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

                    translated += newword + firstLetter + "ay! ";
                }
                else if (vowel != -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword + "way! " ;
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

                    translated += newword + firstLetter + "ay? ";
                }
                else if (vowel != -1 && symbolNumbers == -1)
                {
                    string newword = PunctuationCorrection(restOfWord);
                    translated += newword + "way? ";
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
