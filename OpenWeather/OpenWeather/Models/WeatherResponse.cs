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
        public List<Weather> weather { get; set; }
        public string Base {  get; set; } // modelar
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Clouds clouds { get; set; }
        public Sys sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod  { get; set; }
            }
}
