using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        // Define a dictionary with city names as keys and their respective API URLs as values

        string location = Console.ReadLine();

        string url = $"http://api.weatherapi.com/v1/current.json?key=aa7758b35f384a5eb62102337241405&q={location}&aqi=no";

        using (HttpClient client = new HttpClient())
        {
            try
            {

                HttpResponseMessage response = await client.GetAsync(url);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    JObject data = JObject.Parse(jsonResponse);

                    // Extract relevant weather information
                    string locationName = data["location"]["name"].ToString();
                    string temperature = data["current"]["temp_c"].ToString();
                    string condition = data["current"]["condition"]["text"].ToString();
                    string wind_dir = data["current"]["wind_dir"].ToString();

                    // Display the weather information in the console
                    Console.WriteLine($"Weather in {locationName} ({location}):");
                    Console.WriteLine($"Temperature: {temperature}°C");
                    Console.WriteLine($"Condition: {condition}");
                    Console.WriteLine($"Wind direction: {wind_dir}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve weather data for {location}. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
