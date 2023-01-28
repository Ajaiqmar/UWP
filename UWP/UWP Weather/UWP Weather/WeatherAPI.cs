using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using UWP_Weather;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.IO;

namespace UWP_Weather
{
    internal class WeatherAPI
    {
        internal async static Task<Root> GetWeatherData()
        {
            var location = await LocationAPI.GetCurrentLocation();

            if(location == null)
            {
                return null;
            }

            double lat = location.Coordinate.Latitude;
            double lon = location.Coordinate.Longitude;

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid=a9fdce8b1cc1f799dde732d338bea648");

            var res = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(Root));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(res));

            return serializer.ReadObject(ms) as Root;
        }
    }

    [DataContract]
    public class Coord
    {
        [DataMember]
        public double lon { get; set; }
        [DataMember]
        public double lat { get; set; }
    }

    [DataContract]
    public class Main
    {
        [DataMember]
        public double temp { get; set; }
        [DataMember]
        public double feels_like { get; set; }
        [DataMember]
        public double temp_min { get; set; }
        [DataMember]
        public double temp_max { get; set; }
        [DataMember]
        public int pressure { get; set; }
        [DataMember]
        public int humidity { get; set; }
        [DataMember]
        public int sea_level { get; set; }
        [DataMember]
        public int grnd_level { get; set; }
    }

    [DataContract]
    public class Root
    {
        [DataMember]
        public Coord coord { get; set; }
        [DataMember]
        public List<Weather> weather { get; set; }
        [DataMember]
        public string @base { get; set; }
        [DataMember]
        public Main main { get; set; }
        [DataMember]
        public int visibility { get; set; }
        [DataMember]
        public int dt { get; set; }
        [DataMember]
        public int timezone { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int cod { get; set; }
    }

    [DataContract]
    public class Weather
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string main { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string icon { get; set; }
    }


}
