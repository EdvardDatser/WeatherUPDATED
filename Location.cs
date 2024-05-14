using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class Location
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("region")]
    public string Region { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("lat")]
    public double Latitude { get; set; }

    [JsonProperty("lon")]
    public double Longitude { get; set; }

    [JsonProperty("tz_id")]
    public string TimeZoneId { get; set; }

    [JsonProperty("localtime_epoch")]
    public long LocalTimeEpoch { get; set; }

    [JsonProperty("localtime")]
    public string LocalTime { get; set; }
}

public class Condition
{
    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("icon")]
    public string Icon { get; set; }

    [JsonProperty("code")]
    public int Code { get; set; }
}

public class CurrentWeather
{
    [JsonProperty("last_updated_epoch")]
    public long LastUpdatedEpoch { get; set; }

    [JsonProperty("last_updated")]
    public string LastUpdated { get; set; }

    [JsonProperty("temp_c")]
    public double TemperatureCelsius { get; set; }

    [JsonProperty("temp_f")]
    public double TemperatureFahrenheit { get; set; }

    [JsonProperty("is_day")]
    public int IsDay { get; set; }

    [JsonProperty("condition")]
    public Condition Condition { get; set; }

    // Add other properties as needed
}

public class WeatherApiResponse
{
    [JsonProperty("location")]
    public Location Location { get; set; }

    [JsonProperty("current")]
    public CurrentWeather CurrentWeather { get; set; }
}
