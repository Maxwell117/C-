using system;

namespace itterations
{
    public class Program
    {
        static void Main(string[] args)
        {

         for(int i=0;i<15;i++)
         {
            Console.WriteLine($"{i}");
         }


        }

        public static void meth1()
        {
         for(int i=-1000;i<1000;i++)
         {
            Console.WriteLine($"{i}");
         }
        }
        
        public static void meth2()
        {
         for(int i=3;i<999;i+=3)
         {
            Console.WriteLine($"{i}");
               Console.WriteLine($"{i}");
                  Console.WriteLine($"{i}");
         }
        }

          public static void meth3()
        {
        string a =console.read();
        string b =console.read();
        int ra=convert.toint32(a);
         int rb=convert.toint32(b);

         if(ra==rb)
         {
          Console.WriteLine("equal");  
         }
         else
         {
          Console.WriteLine("not equal"); 
         }
        }

        public static void meth4()
        {
          string a =console.read();
 int ra=convert.toint32(a);
         
         if(ra<0)
         {
          Console.WriteLine("negative");  
         }
         else
         {
          Console.WriteLine("positive");  
         }
        }
    }
}

