
using OpenWeather.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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
        public WeatherResponse WeatherResponse;
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


      
       ////PERSONALIZAR OS ICONS DE CLIMA

        
        ///PROCURAR POR CIDADE

        public async Task<WeatherResponse> getWeatherbyCity(string cityName)
        {
            var url = $"{BaseUrl}?q={cityName}&appid={ApiKey}&units=metric&lang=pt";
        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();// tranforma o conteudo em string;
            WeatherResponse = JsonSerializer.Deserialize<WeatherResponse>(content, jsonSerializerOptions);
        }
    }
    catch
    {

    }
    return WeatherResponse;

}

        //Procurar por coordenadas do gps

        public async Task<WeatherResponse> GetWeatherByGps(string lat, string lon)
        {
            var url = $"{BaseUrl}?lat={lat}&lon={lon}&appid={ApiKey}&units=metric&lang=pt";
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();// tranforma o conteudo em string;
                    WeatherResponse = JsonSerializer.Deserialize<WeatherResponse>(content, jsonSerializerOptions);
                }
            }
            catch
            {

            }
            return WeatherResponse;

        }





    }
}
