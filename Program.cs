// See https://aka.ms/new-console-template for more information
using EDCS.API.Integration.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("EDCS API Integration.");

string contentType = "application/json";

string edcsUrl = "https://edcs-test.ustp.edu.ph";

var userLogin = new LoginCredentials
{
    UsernName = "test_username",
    Password = "test_p@ssw0rd"
};

using (HttpClient client = new HttpClient())
{
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

    StringContent userLoginContent = new StringContent(JsonSerializer.Serialize(userLogin), Encoding.UTF8, contentType);

    Console.Write("User login request..");

    var loginRequest = await client.PostAsync($"{edcsUrl}/login", userLoginContent);

    if (loginRequest.StatusCode == System.Net.HttpStatusCode.OK)
    {
        var loginResponseContent = JsonSerializer.Deserialize<LoginResponse>(await loginRequest.Content.ReadAsStringAsync());

        Console.WriteLine("Uploading PR Payload..");

        string prPayload = File.ReadAllText("PRPayload.json");

        StringContent prPayloadContent = new StringContent(prPayload, Encoding.UTF8, contentType);

        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {loginResponseContent!.AccessToken}");

        HttpResponseMessage prUploadRequest = await client.PostAsync($"{edcsUrl}/promotional-reports/load-pr", prPayloadContent);

        string prUploadResponse = await prUploadRequest.Content.ReadAsStringAsync();

        Console.Write($"PR upload response status: {prUploadResponse}");
    }
    else
    {
        Console.WriteLine("Unable to login user..");
    }
}
