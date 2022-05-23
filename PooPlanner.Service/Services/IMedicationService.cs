﻿using PooPlanner.Shared.DTO;

namespace PooPlanner.Service.Services
{
    public interface IMedicationService
    {
        MedicationGetDto CreateMedication(MedicationPostDto medicationDto);
        IEnumerable<MedicationGetDto> GetAllMedications();
        MedicationGetDto GetMedicationById(long id);
        IEnumerable<MedicationPostDto> GetMedicationByTimestamp(DateTime startTime, DateTime endTime);
    }
}