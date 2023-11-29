using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals == null)
            {
                return false;
            }
            foreach(var items in vals)
            {
                if(items == false)
                {
                    return true;
                }  
            }
            return false;
            

            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for(int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }

            if (isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }
            else return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] myArray = new int[50];
            int index = 0;

            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    myArray[index] = i;
                    index++;
                }
                
            }
            return myArray;
        }
  

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length;i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
