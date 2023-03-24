using System;
using System.Collections.Generic;
using System.Collections.Specialized;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {

        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            HashSet<string> word_set = new HashSet<string>(words);

            if (!ignoreCase)
                if (word_set.Contains(word))
                    return true;

            if (ignoreCase)
                if (word_set.Contains(word))
                    return true;

            return false;

        }

        public bool IsPrimeNumber(int num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                if (num%i == 0)
                return true;
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var map = new OrderedDictionary();
            for (int i = 0; i < str.Length; i++)
            {
                if (map.Contains(str[i]))
                    map[str[i]]++;
                else
                    map[str[i]] = 1;
            }

            int ans = 0;
            foreach(var page in map)
            {
                if (page.Key == 1)
                    ans = page.Value;
            }

            return ans;
        }
        
        public int MaxConsecutiveCount(int[] numbers)
        {
            int cache = -1;
            int cnt = 1;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]==numbers[i+1])
                {
                    cnt++;
                    cache = Math.Max(cache, cnt);
                }
                else
                {
                    cnt = 1;
                }
            }
            return cache;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> n_list = new List<double>();
            for (int i = 0; i < elements.Count; i += n)
            {
                n_list.Add(elements[i]);
            }
            return n_list.ToArray();
        }
    }
}