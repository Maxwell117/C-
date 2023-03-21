console.log("Hello World!\n==========\n");

// Exercise 1 Section
console.log("EXERCISE 1:\n==========\n");
for(let i=0;i<100;i++)
{
  if(i%2==0)
  {
    continue;
  }
  else
  {
    console.log(i);
  }
}

// Exercise 2 Section
console.log("EXERCISE 2:\n==========\n");
for(let i=0;i<100;i++)
{
  if(i%3==0)
  {
    console.log(i,"FIZZ");
  }
  else if(i%5==0)
  {
    console.log(i,"BUZZ");
  }
  else if(i%5==0&&i%3==0)
  {
    console.log(i,"FIZZBUZZ");
  }
}

// Exercise 3 Section
let i=0;
while(i!=100)
{
  if(i%2!=0)
  {
    console.log(i);
  }
  i++;
}

let i=0;
while(i!=100)
{
  if(i%3==0)
  {
    console.log(i,"FIZZ");
  }
  else if(i%5==0)
  {
    console.log(i,"BUZZ");
  }
  else if(i%5==0&&i%3==0)
  {
    console.log(i,"FIZZBUZZ");
  }
  i++;
}

// Exercise 4 Section
let value = Math.round((Math.random() * 500)); // creates a random number between 0 and 500
let n = Math.round(Math.random() * (500 - 100) + 100); // creates a random number between 100 and 500

let flag=true;
for(let i=0;i<n;i++)
{
  if(i==value)
  {
    console.log("Found Value");
    flag=false;
    break;
  }
}
if(flag)
{
  console.log("Did not find Value");
}

// Exercise 5 Section
let fizzDivisor = Math.round(Math.random() * (10 - 1) + 1); // creates a random number between 1 and 10
let buzzDivisor = Math.round(Math.random() * (10 - 1) + 1); // creates a random number between 1 and 10
let start = Math.round(Math.random() * (10 - 1) + 1); // creates a random number between 1 and 10
let end = Math.round(Math.random() * (1000 - 100) + 100); // creates a random number between 100 and 1000

for(let i=start;i<=end;i++)
{
  if(fizzDivisor%3==0)
  {
    console.log(i,"FIZZ");
  }
  else if(buzzDivisor%5==0)
  {
    console.log(i,"BUZZ");
  }
  else if(fizzDivisor%3==0 && buzzDivisor%5==0)
  {
    console.log(i,"FIZZBUZZ");
  }
}
