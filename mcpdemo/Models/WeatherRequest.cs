
namespace mcpdemo.Models
{  
public class WeatherRequest
{
    public Request Request { get; set; }
    public Location Location { get; set; }
    public Current Current { get; set; }
    public Dictionary<string, Historical> Historical { get; set; }
}

public class Request
{
    public string Type { get; set; }
    public string Query { get; set; }
    public string Language { get; set; }
    public string Unit { get; set; }
}

public class Location
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
    public string Lat { get; set; }
    public string Lon { get; set; }
    public string Timezone_id { get; set; }
    public string Localtime { get; set; }
    public long Localtime_epoch { get; set; }
    public string Utc_offset { get; set; }
}

public class Current
{
    public string Observation_time { get; set; }
    public int Temperature { get; set; }
    public int Weather_code { get; set; }
    public List<string> Weather_icons { get; set; }
    public List<string> Weather_descriptions { get; set; }
    public int Wind_speed { get; set; }
    public int Wind_degree { get; set; }
    public string Wind_dir { get; set; }
    public int Pressure { get; set; }
    public int Precip { get; set; }
    public int Humidity { get; set; }
    public int Cloudcover { get; set; }
    public int Feelslike { get; set; }
    public int Uv_index { get; set; }
    public int Visibility { get; set; }
}

public class Historical
{
    public string Date { get; set; }
    public long Date_epoch { get; set; }
    public Astro Astro { get; set; }
    public int Mintemp { get; set; }
    public int Maxtemp { get; set; }
    public int Avgtemp { get; set; }
    public int Totalsnow { get; set; }
    public double Sunhour { get; set; }
    public int Uv_index { get; set; }
    public List<Hourly> Hourly { get; set; }
}

public class Astro
{
    public string Sunrise { get; set; }
    public string Sunset { get; set; }
    public string Moonrise { get; set; }
    public string Moonset { get; set; }
    public string Moon_phase { get; set; }
    public int Moon_illumination { get; set; }
}

public class Hourly
{
    public string Time { get; set; }
    public int Temperature { get; set; }
    public int Wind_speed { get; set; }
    public int Wind_degree { get; set; }
    public string Wind_dir { get; set; }
    public int Weather_code { get; set; }
    public List<string> Weather_icons { get; set; }
    public List<string> Weather_descriptions { get; set; }
    public double Precip { get; set; }
    public int Humidity { get; set; }
    public int Visibility { get; set; }
    public int Pressure { get; set; }
    public int Cloudcover { get; set; }
    public int Heatindex { get; set; }
    public int Dewpoint { get; set; }
    public int Windchill { get; set; }
    public int Windgust { get; set; }
    public int Feelslike { get; set; }
    public int Chanceofrain { get; set; }
    public int Chanceofremdry { get; set; }
    public int Chanceofwindy { get; set; }
    public int Chanceofovercast { get; set; }
    public int Chanceofsunshine { get; set; }
    public int Chanceoffrost { get; set; }
    public int Chanceofhightemp { get; set; }
    public int Chanceoffog { get; set; }
    public int Chanceofsnow { get; set; }
    public int Chanceofthunder { get; set; }
    public int Uv_index { get; set; }
}
}