using PooPlanner.Shared.DTO;

namespace PooPlanner.Service.Services
{
    public interface IMedicineService
    {
        IEnumerable<MedicationDto> GetAllMedications();
        IEnumerable<MedicineGetDto> GetAllMedicines();
        MedicationDto GetMedicationById(long id);
        IEnumerable<MedicationDto> GetMedicationByTimestamp(DateTime startTime, DateTime endTime);
        MedicineGetDto GetMedicineById(long id);
    }
}