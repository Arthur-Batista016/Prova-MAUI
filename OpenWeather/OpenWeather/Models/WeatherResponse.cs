using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Models
{
    internal class WeatherResponse
    {
        public Coord coord {  get; set; }
        public Weather weather { get; set; }
        public Main main { get; set; }
        public Visibility visibility { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Clouds clouds { get; set; }
        public Sys sys { get; set; }
    }
}
