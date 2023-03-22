namespace classes
{
   public class Program
    {
        static void Main(string[] args)
        {
        car honda=new car();
        honda.year=2010;
        honda.model="2A";
        honda.make="x2x";
       Console.writeline("year"+ honda.year + "model "+ honda.model + "make "+honda.make);
        carlist<car>=new list<car>();
        }
    }
}
