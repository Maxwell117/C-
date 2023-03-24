using System;

namespace ChallengesWithTestsMark8
{
    public class Business
    {
        public string Name { get; set; }
    }



    public class ChallengesSet04
    {
     
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int oddsum = 0;
            int evensum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%2!=0)
                    oddsum+=numbers[i];
                else
                    evensum+=numbers[i];

                return evensum - oddsum;
            }
            return 0; //probably wont call but I need to return something
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strings=new List<string> { str1, str2, str3, str4 };
            int min = 99;
            foreach(string s in strings)
            {
                if(min>s.Length)
                    min = s.Length;
            }
            return min;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers=new List<int> {number1, number2, number3, number4 };
            int min = 99;
            foreach (int n in numbers)
            {
                if (min > n)
                    min = n;
            }
            return min;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            HashSet<char> symbols = new HashSet<char>();
            symbols.Add('#');
            symbols.Add('*');

            if (input == null || input.Length == 0)
                return false;
       
            foreach(char c in input)
            {
                if (Char.IsLetter(c))
                    return false;
                else if (symbols.Contains(c))
                    return false;
            }

            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var cnt = 0;
            var half= objs.Length / 2;
            for (int i = 0; i < objs.Length; i++)
            {
                if(objs[i] == null)
                {
                    cnt++;
                }
            }
            if (cnt > half)
                return true;
            else
                return false;

        }

        public double AverageEvens(int[] numbers)
        {
            int sum = 0;
            int cnt = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%2==0)
                {
                    sum+=numbers[i];
                    cnt++;
                }

            }
            return sum/cnt;
        }

        public int Factorial(int number)
        {
            if (number < 0||number==0)
                return 1;
            return number * Factorial(number - 1);
        }

    }
}