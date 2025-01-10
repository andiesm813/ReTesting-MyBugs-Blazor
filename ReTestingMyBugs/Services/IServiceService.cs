using ReTestingMyBugs.Models.Service;

namespace ReTestingMyBugs.Service
{
    public interface IServiceService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}
