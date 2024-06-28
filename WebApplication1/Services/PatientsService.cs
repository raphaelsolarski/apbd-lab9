using WebApplication1.Dto;
using WebApplication1.Repository;

namespace WebApplication1.Services;

public class PatientsService(IPatientsRepository patientsRepository) : IPatientsService
{
    public PatientInfoDto? GetPatientInfo(int id)
    {
        
        throw new NotImplementedException();
    }
}