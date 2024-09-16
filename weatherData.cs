﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class WeatherData
    {
        public Coord Coord {  get; set; }
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Sys Sys { get; set; }
        public string Name { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public int Cod { get; set; }
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
        public double feelsLike { get; set; }
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
        public string country { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
    }

}
