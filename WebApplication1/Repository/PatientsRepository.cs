using WebApplication1.Context;

namespace WebApplication1.Repository;

public class PatientsRepository : IPatientsRepository
{
    public Patient? findPatientByProperties(PrescriptionsContext context, string firstName, string lastName, DateOnly birthdate)
    {
        return context.Patients.SingleOrDefault(p =>
            p.Birthdate == birthdate &&
            p.FirstName == firstName &&
            p.LastName == lastName);
    }

    public Patient CreatePatient(PrescriptionsContext context, Patient patient)
    {
        context.Patients.Add(patient);
        throw new NotImplementedException();
    }
}