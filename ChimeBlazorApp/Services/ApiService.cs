// ApiService.cs
using System.Net.Http;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient httpClient;
    private const string baseUrl = "https://pulud6u8je.execute-api.us-east-1.amazonaws.com/Prod/create?m=123";

    public ApiService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<string> GetApiResponse()
    {
        // Replace "your-api-endpoint" with the actual endpoint of your REST API
        var response = await httpClient.GetAsync(baseUrl);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        else
        {
            return "Error fetching data from the API";
        }
    }
}
