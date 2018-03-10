
using Lab4WebApplication.Controllers;
using Lab4WebApplication.Data.Entities;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HttpClientSample
{

  class Program
  {
    /*
    static HttpClient client = new HttpClient();

    static void DisplayPets()
    {
      var userId = User.Identity.GetUserId();

      _log.Debug("Getting list of pets for user: " + userId);

      var petViewModels = _petService.GetPetsForUser(userId);

      return View(petViewModels);

      Console.WriteLine($"Name: {pet.Name}\tAge: " +
          $"{pet.Age}\tCheckup: {pet.NextCheckup.ToString()}");
    }
*/
    static void Main()
    {
  //    RunAsync().GetAwaiter().GetResult();
    }
    /*
        static async Task RunAsync()
        {
          // Update port # in the following line.
          client.BaseAddress = new Uri("http://http://localhost:15307/");
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(
              new MediaTypeWithQualityHeaderValue("application/json"));

          try
          {
            // Create a new product
            Product product = new Product
            {
              Name = "Gizmo",
              Price = 100,
              Category = "Widgets"
            };

            var url = await CreateProductAsync(product);
            Console.WriteLine($"Created at {url}");

            // Get the product
            product = await GetProductAsync(url.PathAndQuery);
            ShowProduct(product);

            // Update the product
            Console.WriteLine("Updating price...");
            product.Price = 80;
            await UpdateProductAsync(product);

            // Get the updated product
            product = await GetProductAsync(url.PathAndQuery);
            ShowProduct(product);

            // Delete the product
            var statusCode = await DeleteProductAsync(product.Id);
            Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

          }
          catch (Exception e)
          {
            Console.WriteLine(e.Message);
          }

          Console.ReadLine();
        }
        */
  }
}
