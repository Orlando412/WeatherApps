using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class weatherData
    {
        public Coord coord {  get; set; }
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public string name { get; set; }
        public string timezone { get; set; }
        public string id { get; set; }
        public string cod { get; set; }
    }

    internal class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    internal class Weather
    {
        public string id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    internal class Main
    {
        public double temp { get; set; }
        public double feels_Like { get; set; }
        public double temp_Min { get; set; }
        public double temp_Max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        
    }

    internal class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    internal class Clouds
    {
        public int all { get; set; }
    }

    internal class Sys
    {
        public string Country { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
    }

}
