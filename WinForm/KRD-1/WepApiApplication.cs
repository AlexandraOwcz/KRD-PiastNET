using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;


namespace KRD_1
{
    public class WebApiApplication
    {
        private HttpClient _httpClientInstance;

        public WebApiApplication()
        {
            _httpClientInstance = new HttpClient();
            _httpClientInstance.BaseAddress = new Uri("http://localhost:58432/");
            _httpClientInstance.DefaultRequestHeaders.Accept.Clear();
            _httpClientInstance.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        void ShowPackage(Package package) => Console.WriteLine($"Id: {package.Id}\tStatus: " +
                $"{package.Status}\tGodzina: {package.Hour}");

        async Task<Package> GetPackageAsync(string path)
        {
            Package package = null;
            HttpResponseMessage response = await _httpClientInstance.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                package = await response.Content.ReadAsAsync<Package>();
            }
            return package;
        }

        async Task<Package> UpdateProductAsync(Package package)
        {
            HttpResponseMessage response = await _httpClientInstance.PutAsJsonAsync(
                $"api/PackageController/Update/{package.Id}", package);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            package = await response.Content.ReadAsAsync<Package>();
            return package;
        }

        async Task<Uri> CreatePackageAsync(Package package)
        {
            HttpResponseMessage response = await _httpClientInstance.PostAsJsonAsync(
                "api/PackageController/AddPackage", package);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        async Task<HttpStatusCode> DeletePackageAsync(string id)
        {
            HttpResponseMessage response = await _httpClientInstance.DeleteAsync(
                $"api/PackageController/Delete/{id}");
            return response.StatusCode;
        }
    }
}