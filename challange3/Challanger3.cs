using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool flag = false;
            for(int i=0;i<vals.Length;i++)
            {
                if (vals[i] == false)
                    flag = true;
            }
            return flag;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach(int n in numbers)
            {
                if (n%2!=0)
                    sum += n;
            }
            if (sum % 2 != 0)
                return true;
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool flag1= false; bool flag2 = false;  bool flag3 = false;
            for(int n=0;n<password.Length;n++)
            {
                if (Char.IsDigit(password[n]))
                    flag1 = true;
                else if (Char.IsLower(password[n]))
                    flag2 = true;
                else if(Char.IsUpper(password[n]))  
                    flag3= true;
            }

            if (flag1 && flag2 && flag3)
                return true;
            else
                return false; 
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> list = new List<int>();
            for(int i=0;i<100;i++)
            {
                if(i%2!=0)
                    list.Add(i);
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i=0;i<words.Length;i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}