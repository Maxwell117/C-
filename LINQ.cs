using System;
using system.linq;
namespace LINQ
{

     

  private static int[] nums={0,1,2,3,4,5,6,7,8,9};
    class Program
    {
        static void Main(string[] args)
        {
            var sum=nums.sum();
            var av=nums.average();
            nums[3]=5;
            var ordered=nums.orderby(num=>num);
            var inordered=nums.orderbydescending(x=>x);
            Console.writeline("sum" + sum);
             Console.writeline("average" + av);
             
             var filter=employees.where(person=>person.firstname[0]==('C')||person.firstname[0]==('S').orderby
             var over26=employees.where(person=>person.age>26).orderby(person=>person.age).thenby(person=>person.firstname);
             var years=employees.where(peroson=>person.yearsofexperience<=10&&person.age>35);
             var sumYOE=employees.sum(person=>person.yearsofexperience);
             foreach(subset in nums.take(5))
             {

             }
             var res=nums.where(x=>x>6)
        }
    }
}
