using System;
using System.Collections.Generic;

namespace MiscLib {
    public class GroupTwoFunctions {
        //---- Group 2 Functions ----------
        public int CalcRectPerimeter (int length, int width) {

            //converts length into positive
            if (length < 0) {
                length = ((length - length) - length);
            }
            //converts width into positive
            if (width < 0) {
                width = ((width - width) - width);
            }
            //runs after converting 
            int result = ((length + width) * 2);
            return result;
        }

        public bool IsTriangularNum (int num) {

            int result = 0;

            for (int i = 1; i <= num; i++) {
                result = result + i;
                if (result == num) {
                    return true;
                }
            }
            return false;
        }

        public int FarenheitToCelcius (int farenheit) {

            double celsius = 0;
            //convert farenheit from int to double to get fractions
            double Dfarenheit = Convert.ToDouble (farenheit);

            celsius = (Dfarenheit - 32) * 5 / 9;
            celsius = Math.Ceiling (celsius);
            if (celsius < 0) {
                celsius = celsius - 1;
            }
            //convert from double back to int
            int x = Convert.ToInt32 (celsius);
            return x;
        }



        public bool CheckWhiteSpace (string word) {
            bool x = word.Contains (" ");
            return x;
        }


        public string CamelString (string word) {
            // this shit was fucked Matt...

            var charArr = new char[word.Length];
            var UorL = "U";

            for (int i = 0; i < word.Length; i++) {

                if (UorL == "U") {
                    if (word[i] == ' ') {
                        charArr[i] = word[i];
                        UorL = "U";
                    } else if (char.IsLower (word[i])) {
                        charArr[i] = char.ToUpper (word[i]);
                        UorL = "L";
                    } else if (char.IsUpper (word[i])) {
                        charArr[i] = (word[i]);
                        UorL = "L";
                    }
                } else if (UorL == "L") {
                    if (word[i] == ' ') {
                        charArr[i] = word[i];
                        UorL = "L";
                    } else if (char.IsUpper (word[i])) {
                        charArr[i] = char.ToLower (word[i]);
                        UorL = "U";
                    } else if (char.IsLower (word[i])) {
                        charArr[i] = (word[i]);
                        UorL = "U";
                    }
                }
            }
                string s = string.Join ("", charArr);
                return s;
        }

        public int CountDigits (string word) {

            int NumCount = 0;
            foreach (char c in word) {
                if (Char.IsDigit (c))
                    NumCount++;
            }
            return NumCount;
        }

    }
}