
using Newtonsoft.Json.Linq;

var client = new HttpClient();

Console.WriteLine("Please enter your API key: ");

var api_key = Console.ReadLine();

while(true)
{
    Console.WriteLine();
    Console.WriteLine("Please enter the city name: ");
    var city_name = Console.ReadLine();

    var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid={api_key}&units=imperial";

    var response = client.GetStringAsync(weatherURL).Result;

    var formattedResponse = JObject.Parse(response).GetValue("main").ToString();

    Console.WriteLine(formattedResponse);

    Console.WriteLine();

    Console.WriteLine("Would you like to choose a different city?");
    var userInput = Console.ReadLine();

    if(userInput.ToLower() == "no")
    {
        break;
    };
}

