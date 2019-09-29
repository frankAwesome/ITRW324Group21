using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class CommicProcessor
    {


        public static async Task<CommicModel> LoadCommic(int commicNumber = 0)
        {
            string url = "";

            if (commicNumber > 0)
            {
                url = $"https://localhost:44367/api/values/" + commicNumber.ToString() ;
            }
            else
            {
                //Moet by laaste een begin
                url = $"https://localhost:44367/api/values/";
            }

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CommicModel commic = await response.Content.ReadAsAsync<CommicModel>();




                    return commic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        } 
    }
}
