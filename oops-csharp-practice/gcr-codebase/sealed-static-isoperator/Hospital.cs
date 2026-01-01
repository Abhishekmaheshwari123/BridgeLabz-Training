using System;

class Patient
{
    public static string HospitalName = "City Hospital";
    public static int TotalPatients = 0;

    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(int id, string name, int age, string ailment)
    {
        this.PatientID = id;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;

        TotalPatients++;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + TotalPatients);
    }

    public void ShowDetails()
    {
        if (this is Patient)
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Patient ID: " + PatientID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
        }
    }

    static void Main(string[] args)
    {
        Patient p1 = new Patient(1, "Abhi", 22, "Fever");
        Patient p2 = new Patient(2, "Riya", 25, "Injury");

        p1.ShowDetails();
        Console.WriteLine();
        p2.ShowDetails();

        Console.WriteLine();
        Patient.GetTotalPatients();
    }
}
