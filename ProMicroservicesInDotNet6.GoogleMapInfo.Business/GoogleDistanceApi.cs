using Microsoft.Extensions.Configuration;
using System.Text.Json;
using ProMicroservicesInDotNet6.GoogleMapInfo.Business.Models;
using System.Collections.Generic;
using System;

namespace ProMicroservicesInDotNet6.GoogleMapInfo.Business
{
    public class GoogleDistanceApi
    {
        private readonly IConfiguration _configuration;

        public GoogleDistanceApi(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public async Task<GoogleDistanceData> GetMapDistance(string originCity, string destinationCity)
        //{
        //    var apiKey = _configuration["googleDistanceApi:apiKey"];
        //    var googleDistanceApiUrl = _configuration["googleDistanceApi:apiUrl"];
        //    googleDistanceApiUrl += $"units=imperial&origins={originCity}&destinations={destinationCity}&key={apiKey}";

        //    using var client = new HttpClient();
        //    var request = new HttpRequestMessage(HttpMethod.Get, new Uri(googleDistanceApiUrl));
        //    var response = await client.SendAsync(request);
        //    response.EnsureSuccessStatusCode();

        //    await using var data = await response.Content.ReadAsStreamAsync();
        //    var distanceInfo = await JsonSerializer.DeserializeAsync<GoogleDistanceData>(data);
        //    return distanceInfo;
        //}

        public async Task<GoogleDistanceData> GetMapDistance(string originCity, string destinationCity)
        {
            await Task.Delay(1000);
            return
                new GoogleDistanceData
                {
                    destination_addresses = new string[] { "Los Angeles CA, USA" },
                    origin_addresses = new string[] { "Dallas, TX, USA" },
                    rows = new Row[]
                        {
                            new Row
                            {
                                elements = new Element[]
                                {
                                new Element
                                    {
                                        distance= new Distance
                                        {
                                            text= "2,311 km",
                                            value = 2310980,
                                        },
                                        duration= new Duration
                                        {
                                        text= "20 hours 52 mins",
                                        value = 75108,
                                        },
                                        status= "OK"
                                    }
                                }

                            }
                       },
                    status = "OK"
                };
        }
    }
}