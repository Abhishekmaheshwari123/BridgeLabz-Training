using System;

class Program
{
    static void Main()
    {
        AmbulanceRoute route = HospitalSetup.InitializeHospital();
        PatientRedirector redirector = new PatientRedirector(route);

        route.DisplayRoute();

        redirector.RedirectPatient();
        redirector.RedirectPatient();

        route.DisplayRoute();

        route.RemoveUnit("Radiology");

        route.DisplayRoute();

        redirector.RedirectPatient();
    }
}
