class HospitalSetup
{
    public static AmbulanceRoute InitializeHospital()
    {
        AmbulanceRoute route = new AmbulanceRoute();

        route.AddUnit("Emergency");
        route.AddUnit("Radiology");
        route.AddUnit("Surgery");
        route.AddUnit("ICU");

        return route;
    }
}
