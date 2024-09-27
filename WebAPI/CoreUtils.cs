using Newtonsoft.Json.Linq;
using SwarmUI.WebAPI;

namespace Hartsy.Extensions.Core.WebAPI
{
    public class CoreUtils : HartsyCoreAPI
    {
        public async static Task<JObject> CheckValidURL(
            [API.APIParameter("URL to check")] string url)
        {
            JObject response = [];
            try
            {
                Uri uri = new(url);
                response["valid"] = true;
                response["message"] = "The URL is valid.";
            }
            catch (UriFormatException ex)
            {
                response["valid"] = false;
                response["message"] = "Invalid URL format.";
                response["error"] = ex.Message;
            }
            catch (Exception ex)
            {
                response["valid"] = false;
                response["message"] = "An unexpected error occurred.";
                response["error"] = ex.Message;
            }
            return await Task.FromResult(response);
        }
    }
}

