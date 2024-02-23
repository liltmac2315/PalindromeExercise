using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForPalindrome
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word) 
        {
            //reverse the word 
            var reversed = "";

            for (int i = word.Length -1; i >= 0; i--)
            {
                reversed += word[i];
            }

            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else 
            { 
                return false;
            }

            //var reversedword = word.Reverse();
            //return word.ToLower().SequenceEqual(reversedword);

            //var reversed = word.Reverse();

            //if(reversed.ToString() == word) 
            //{
               //return true;
            //}
            //else 
            //{
                //return false;
            //}

            //compare the original with the reversed

            //return wether they are the same or not
        }
    }
}
