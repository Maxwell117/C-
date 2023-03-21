using system;
namespace FizzBuzz
{
    class FB 
    {         
        public string FizzBuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)  
            {  
            return "FizzBuzz";  
            }  
            else if (i % 3 == 0)  
            {  
            return "Fizz";  
            }  
            else if (i % 5 == 0)  
            {  
            return "Buzz";  
            }  
        }


        static void Main(string[] args)
        {
            string t=FizzBuzz(5);
            console.writeline(t);
        
         
        }
    }
}
