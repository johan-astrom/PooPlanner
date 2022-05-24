using PooPlanner.Shared.DTO;

namespace PooPlanner.Service.Services
{
    public interface IStoolService
    {
        StoolGetDto CreateStool(StoolPostDto postDto);
        IEnumerable<StoolGetDto> GetAllStools();
        StoolGetDto GetStoolById(long id);
        IEnumerable<StoolGetDto> GetStoolByTimestamp(DateTime startTime, DateTime endTime);
    }
}