using System;
using System.Collections.Generic;
namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet02
    {
      
        public bool CharacterIsALetter(char s)
        {
            if(char.IsLetter(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CharacterIsNotALetter(char s)
        {
            if (!char.IsLetter(s))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CountOfElementsIsEven(string[] s)
        {
            if(s.Length%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            int min = (int)numbers.Min();
            int max = (int)numbers.Max();

            return max - min;

        }

        public int GetLengthOfShortestString(string str1,string str2)
        {
            if (str1.Length>str2.Length)
                return str2.Length;
            else if (str1.Length<str2.Length)
                return str1.Length;
            else
                return str1.Length;
        }

        public int Sum(int[] nums)
        {
            int sum = 0;
            for(int i=0;i<nums.Length;i++)
            {
            sum+=nums[i];
            }
            return sum;
        }

        public int SumEvens(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2== 0)
                sum += nums[i];
            }
            return sum;
        }

        public bool IsSumOdd(List<int> nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            if (sum % 2 != 0)
                return true;
            else
                return false;
        }

        public double CountOfPositiveOddsBelowNumber(int number)
        {
            if(number<0)
                return 0;
            int cnt = 0;

            do
            {
                number--;
                if (number % 2 != 0)
                    cnt++;
            } while (number != 0);

            return cnt;    
        }

    }
}