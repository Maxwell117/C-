using System;
namespace PalindromeExerciseTests
{
    public class Palin
    {
        public string Palindrome(string word)
        {
           string rev= new string(word.Reverse().ToArray());
            return rev;
        }

    }
}