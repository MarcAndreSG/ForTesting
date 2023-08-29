using Newtonsoft.Json;

namespace WinFormsApp1.Model
{
    public class Form1Model
    {

        public async Task<List<Post>> testcAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("https://my-json-server.typicode.com/typicode/demo/posts").Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<List<Post>>(json);
                }
            }

            return new List<Post>();
        }
    }
}
