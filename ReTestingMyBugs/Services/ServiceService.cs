using System.Net.Http.Json;
using ReTestingMyBugs.Models.Service;

namespace ReTestingMyBugs.Service
{
    public class ServiceService: IServiceService
    {
        private readonly HttpClient _http;

        public ServiceService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/service-box-office-revenue-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<BoxOfficeRevenueType>>().ConfigureAwait(false);
            }

            return new List<BoxOfficeRevenueType>();
        }
    }
}
