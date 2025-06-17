using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using FakeStoreApiCLient;

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");


//var product = await httpClient.GetFromJsonAsync<Product>("products/1");
//
//product.Price = 1000;
//
//var response = await httpClient.PutAsJsonAsync("products/1", product);

var response = await httpClient.DeleteAsync("products/1");
Console.WriteLine(response);