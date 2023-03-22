using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
namespace LocalWeatherAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var key = "2b6d5dc8f2d6c722ee525010a990545b";
            var city = "Queens";

          //var weatherURL = "http://api.openweathermap.org/data/2.5/forecast?g={city}&appid={key}&units=imperial";
         // var res=client.GetStringAsync(weatherURL).Result;

      //    JObject formattedRes = JObject.Parse(res);
        //  var temp = formattedRes["list"][0]["main"]["temp"];//lets us dig into JSON by array indexes
         // Console.WriteLine(temp);

            while(true)
            {
             
                Console.Write("Please enter your city");
                var user_city=Console.ReadLine();
                Console.WriteLine();
                var weatherURL = "http://api.openweathermap.org/data/2.5/forecast?g={user_city}&appid={key}&units=imperial";
                try
                { 
                    var res = client.GetStringAsync(weatherURL).Result;
                    var formattedRes = JObject.Parse(res).GetValue("main").ToString();
                    var temp = JObject.Parse(formattedRes).GetValue("temp");
                    Console.WriteLine("Current Temperature is " + temp + " degrees fahrenheit");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
             
                Console.WriteLine("Want to exit? yes");
                var end=Console.ReadLine();

                if (end == "yes")
                    break;
            }
             
        }
    }
}
