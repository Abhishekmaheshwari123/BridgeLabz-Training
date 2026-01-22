using System;

class PatientRedirector
{
    private AmbulanceRoute route;

    public PatientRedirector(AmbulanceRoute route)
    {
        this.route = route;
    }

    public void RedirectPatient()
    {
        HospitalUnit unit = route.FindNearestAvailableUnit();

        if (unit == null)
        {
            Console.WriteLine("No unit available. Redirect to another hospital.");
        }
        else
        {
            Console.WriteLine("Patient redirected to: " + unit.Name);
            unit.IsAvailable = false;
        }
    }
}
