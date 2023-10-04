
using Imtihon04_10_2023;
using Newtonsoft.Json;

using(HttpClient client = new HttpClient())
{
    string Base_Url= "https://jsonplaceholder.typicode.com/posts";
    HttpResponseMessage responce = await client.GetAsync(Base_Url);
    string JsonData = await responce.Content.ReadAsStringAsync();
    List<User> Data = JsonConvert.DeserializeObject<List<User>>(JsonData);
    foreach(var j in Data)
    {
        Console.WriteLine("userId- {0}",j.userId);
        Console.WriteLine("id- {0}", j.id);
        Console.WriteLine("tiitle-{0}", j.title);
        Console.WriteLine("body-{0}", j.body);
        Console.WriteLine("//////////////////////////////////////");
    }
}