﻿using OpenWeather.Models;
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
        public WeatherResponse weatherResponse;
        private JsonSerializerOptions jsonSerializerOptions;

        public AppService()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
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
                    weatherResponse = JsonSerializer.Deserialize<WeatherResponse>(content, jsonSerializerOptions);
                    if (weatherResponse == null)
                    {
                        Console.WriteLine("A deserialização retornou nulo.");
                    }
                }
                else
                {
                    Console.WriteLine($"Falha ao chamar a API. Código de status: {response.StatusCode}");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fazer a chamada da API: {ex.Message}");
            }

            return weatherResponse;
        }


      


    }
}