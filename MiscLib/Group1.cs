using System;

namespace MiscLib {
    public class GroupOneFunctions {
        //---- Group 1 Functions ----------
        public int CalcRectArea (int length, int width) {

            int x = (length * width);
            return x;

            // throw new NotImplementedException ();
        }

        public bool IsFactiorialNum (int num) {
            // throw new NotImplementedException ();
            ///need to wrap this in a while loop to exit at the else for a missed attempt
      for (int i = 1;; i++)  
      {  
          if (num % i == 0)  
          {  
            num /= i;  
          }  
          else
          {  
            break;
          }  
      } 
        if (num == 1)  
        {  
          return true;  
        }  
        else
        {  
          return false;  
        }   


        }

        public int CelciusToFarenheit (int celcius) {
            // throw new NotImplementedException ();

             { 
      return ((celcius * 9 / 5) + 32);
    } 
    
        }

        public bool IsPalindrome (string word) {
            // throw new NotImplementedException ();

            string first = word.Substring(0, word.Length / 2);
            Char[] array = word.ToCharArray(0, word.Length);
            Array.Reverse(array);
            string reverseword = array.ToString();
            string second = reverseword.Substring(0, reverseword.Length / 2);
            return first.Equals(second);
        }

        public string StringReplace (string word, char replaceChar, char replacement) {
            throw new NotImplementedException ();
        }

        public int CharCount (string word, char countCharacter) {
            throw new NotImplementedException ();
        }

    }
}