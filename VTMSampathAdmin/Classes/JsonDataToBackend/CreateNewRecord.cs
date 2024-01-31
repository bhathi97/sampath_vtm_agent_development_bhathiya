using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VTMSampathAdmin.Classes.JsonDataToBackend
{
    class CreateNewRecord : ICreateNewRecord
    {
        public async Task CreateNewApplicationRecord(string endpoint, string contentJson)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(endpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        //show success messege

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
