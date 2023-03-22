using system;
using System.Collections.Generic;
namespace arraysandlists
{
    public class Program
    {
        static void Main(string[] args)
        {
        int[] nums={1,2,3,4,5,6,7,8,9,10};
        list<int> even=new list<int>();
        list<int> odd=new list<int>();

        for(int i=0;i<nums.length;i++)
        {
            if(nums[i]%2==0)
            {
            Console.WriteLine(nums[i]+"is even");
            even.add(nums[i]);
            }
            else
            {
             Console.WriteLine(nums[i]+"is odd");
            odd.add(nums[i]);
            }
        }
       }
    }
}
