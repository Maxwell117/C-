//exercise 1
function printodds(n)
{
	for(let i=0;i<n;i++)
	{
 		if(i%2!=0)
		{
        Console.Log(i+" is odd");
		}
	}
}

//exercise 2
function checkage(age,name)
{
	if(age>16)
    {
	Console.Log("Congrats ${name}, you can drive!");
    }
	else
	{
	Console.Log("Sorry ${userName}, but you need to wait until you're 16.");
	}
}

//exercise 3
function Quadmarker(x,y)
{
	if(x==0)
    {
	Console.Log(x+y+ "is on the y axis")
    }
	else if(y==0)
	{
	Console.Log(x+y+" is on the x axis")
	}
    else if(x>0&&y>0)
    {
	Console.Log(x+y+" is on the 1 quadrant")
    }
    else if(x<0&&y<0)
	{
	Console.Log(x+y," is on the 4 quadrant")
	}
    else if(x<0&&y>0)
	{
	Console.Log(x+y+" is on the 2 quadrant")
	}
    else if(x>0&&y<0)
	{
	Console.Log(x+y+ "is on the 3 quadrant")
	}

}

//exercise 4
function TriangleClassifier(a,b,c)
{
      var sum=a+b;
      
      var ans="";
      if(sum>c)
      {
      ans="Invalid Triangle";
      }
     else if(a==b&&a==c)
     {
     ans="Equilateral Triangle";
     }
     else if(a==b||a==c)
     {
     ans="Isosceles Triangle";
     }
     else
     {
      ans="Scalene Triangle";
     }

     return ans;
}

//exercise 5
function Dataplan(planlimit,usage,day)
{
     const daysleft=30-day;
     console.log(day+" days used "+daysleft+ " days left");

    var ave=planlimit/30;
    var your_ave=  usage/day;
    var rem=0; 
    
    console.log("average daily use is "+your_ave + GB/Day);
   
    if(ave>your_ave)
    {
     console.log("You are UNDER the average usage" +ave);
    } 
     if(ave<your_ave)
    {
     rem=ave-your_ave;;
     console.log("You are EXCEEDING the average usage "+ave +" try to stay below "+ rem);
    }
   Else
   {
   console.log("You are on PAR with the average usage "+ave);
   }

     
 }
