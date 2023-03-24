using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class Business
    {
        public string Name { get; set; }
        public double  TotalRevenue { get; set; }

        public double TotalExpenses { get; set; }

        public Business ParentCompany { get; set; }


    }

    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1)* n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalExpenses==0)
                {
                    businesses[i].Name = "Closed";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            int[] asc=new int[numbers.Length];
            Array.Copy(numbers,asc,numbers.Length);
            for(int i = 0; i < asc.Length; i++)
            {
                if(numbers[i] != asc[i])
                    return false;
            }


            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers.Length == 0 || numbers == null)
                return 0;

            for(int i = 1; i<numbers.Length; i++)
            {
                if(numbers[i-1]%2==0)
                    sum+=numbers[i];
            }
            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            List<string> sentence = new List<string>();
            foreach(string word in words)
                sentence.Add(word);

            return sentence.ToString();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> four_list = new List<double>();
            for(int i = 0; i < elements.Count; i+=4)
            {
                four_list.Add(elements[i]);
            }
            return four_list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var twosum = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int rem = targetNumber - nums[i];
                if(twosum.ContainsKey(rem))
                {
                    return true;
                }
                twosum.Add(nums[i], i);
            }
            return false;
        }

    }
}