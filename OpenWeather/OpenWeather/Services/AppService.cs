
using OpenWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace OpenWeather.Services
{
    internal class AppService
    {
        private HttpClient httpClient;
        private string ApiKey = "15d05aa6d398085bd0bc3088d06a1e49";
        private string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";
        private JsonSerializerOptions jsonSerializerOptions; 
        
        public AppService()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }


        ///PROCURAR POR CIDADE

        public async Task<WeatherResponse> getWeatherbyCity(string cityName)
        {
            var url = $"{BaseUrl}?q={cityName}&appid={ApiKey}&units=metric&lang=pt";
            return null;
              
        }

        //Procurar por coordenadas do gps

        public async Task<WeatherResponse> getWeatherByGps(string lat, string lon)
        {
            var url = $"{BaseUrl}?lat={lat}&lon={lon}&appid={ApiKey}&units=metric&lang=pt";
            return null;
        }


      

    }
}
