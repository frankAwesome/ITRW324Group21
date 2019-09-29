using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfApp5;

namespace WindowsFormsApp9
{
    public class WeatherProcessor
    {

        public static async Task<WeatherModel> LoadWeatherInfo()
        {

        
            string url = $"https://api.openweathermap.org/data/2.5/weather?q=Potchefstroom,za&appid=92562ced8e4daf4b12492fbde0e5edfd&units=metric";
 

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherMainModel main = await response.Content.ReadAsAsync<WeatherMainModel>();




                    return main.Main;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }


        }


        public static async Task<WindModel> LoadWeatherWind()
        {


            string url = $"https://api.openweathermap.org/data/2.5/weather?q=Potchefstroom,za&appid=92562ced8e4daf4b12492fbde0e5edfd&units=metric";


            using (HttpResponseMessage responsetwo = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (responsetwo.IsSuccessStatusCode)
                {
                    WeatherMainModel wind = await responsetwo.Content.ReadAsAsync<WeatherMainModel>();




                    return wind.Wind;
                }
                else
                {
                    throw new Exception(responsetwo.ReasonPhrase);
                }
            }


        }


    }
}
