using system;

namespace overloading
{
    public class Program
    {
        static void Main(string[] args)
        {
          int a=add(1,5);
          int b=add(0.2,0.5);
          int c=add(1,5,true);
        }

        static int add(int x, int y)
        {
        return x + y;
        }

        static double add(decimal x, decimal y)
        {
        return x + y;
        }

        static void add(int x, int y,bool flag)
        {
             int z=x+y;
            if(flag==true&&z==1)
            {
            console.writeline(z+"dollar");
            }
            else
            {
                console.writeline(z+"dollars");
            }

        }

    }
}

