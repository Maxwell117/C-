using System;

public static class Kata
{
  public static ulong OddCount(ulong n)
  {
    int count=0;
    
    for(int i=0;i<n;i++)
    {
      if(i%2!=0)
      {
       count++; 
      }
      
      console.writeline("count is "+count);
    }
  }
}
