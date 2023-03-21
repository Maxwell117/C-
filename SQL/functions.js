//exercise 1
Function printodds(n)
{
	for(let i=0;i<n;i++)
	{
 		if(i%2!=0)
		{
                       Console.Log(i+” is odd”’);
		}
	}
}

//exercise 2
Function checkage(age,name)
{
	if(age>16)
           {
	Console.Log("Congrats ${name}, you can drive!”);
           }
	else
	{
	Console.Log("Sorry ${userName}, but you need to wait until you're 16.");
	}
}

//exercise 3
Function Quadmarker(x,y)
{
	if(x==0)
           {
	Console.Log((${x},${y}) is on the y axis”);
           }
	else if(y==0)
	{
	Console.Log((${x},${y}) is on the x axis”);
	}
           else if(x>0&&y>0)
	{
	Console.Log((${x},${y}) is on the 1 quadrant”);
	}
           else if(x<0&&y<0)
	{
	Console.Log((${x},${y}) is on the 4 quadrant”);
	}
            else if(x<0&&y>0)
	{
	Console.Log((${x},${y}) is on the 2 quadrant”);
	}
            else if(x>0&&y<0)
	{
	Console.Log((${x},${y}) is on the 3 quadrant”);
	}

}

//exercise 4
Function TriangleClassifier(a,b,c)
{
      Var sum=a+b;
      
      Var ans=””;
      if(sum>c)
      {
      ans=”Invalid Triangle”;
      }
     Else if(a==b&&a==c)
     {
     ans=”Equilateral Triangle”;
     }
     Else if(a==b||a==c)
     {
     ans=”Isosceles Triangle”;
     }
     Else
     {
      ans=”Scalene Triangle”;
     }

     return ans;
}

//exercise 5
Function Dataplan(planlimit,usage,day)
{
     Const daysleft=30-day;
     console.log(day+” days used ”+daysleft+ “ days left”);

    var ave=planlimit/30;
    var your_ ave=  usage/day;
    Var rem=0; 
    
    console.log(“average daily use is ”+your_ave + “GB/Day”);
   
    if(ave>your_ave)
    {
     console.log(“You are UNDER the average usage ”+ave);
    } 
     if(ave<your_ave)
    {
     rem=ave-your_ave;;
     console.log(“You are EXCEEDING the average usage ”+ave +”try to stay below ”+ rem);
    }
   Else
   {
   console.log(“You are on PAR with the average usage ”+ave);
   }

     
 }
