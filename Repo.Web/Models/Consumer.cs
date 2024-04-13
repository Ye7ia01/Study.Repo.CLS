namespace Repo.Web.Models
{
    public class Consumer
    {
        private readonly string baseAddress = "http://itesharemmm-001-site1.gtempurl.com/api/Employee/GetEmployees";
        private HttpClient client;
        public Consumer()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
        }


        public IEnumerable<T> Get<T>(string apiName)
        {
            var res = client.GetAsync(apiName).Result;
            var data = res.Content.ReadAsAsync<IEnumerable<T>>().Result;
            return data;
        }
        public T GetById<T>(string apiName)
        {
            var res = client.GetAsync(apiName).Result;
            var data = res.Content.ReadAsAsync<T>().Result;
            return data;
        }
        public bool Create(string apiName, object o) 
        {
            var postTask = client.PostAsJsonAsync(apiName, o );
            postTask.Wait();
            var result = postTask.Result;
            return result.IsSuccessStatusCode;
        }
        public bool Delete(string apiName)
        {
            var postTask = client.DeleteAsync(apiName);
            postTask.Wait();
            var result = postTask.Result;
            return result.IsSuccessStatusCode;
        }

        public bool Update(string apiName, object o)
        {
            var postTask = client.PutAsJsonAsync(apiName, o);
            postTask.Wait();
            var result = postTask.Result;
            return result.IsSuccessStatusCode;
        }
    }
}
