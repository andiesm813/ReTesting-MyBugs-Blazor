using ReTestingMyBugs.Models.Service;

namespace ReTestingMyBugs.Service
{
    public class MockServiceService : IServiceService
    {
        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }
    }
}
