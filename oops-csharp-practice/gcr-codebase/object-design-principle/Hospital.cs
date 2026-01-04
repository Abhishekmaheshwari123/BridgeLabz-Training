using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
}

class Doctor
{
    public string Name { get; set; }

    public void Consult(Patient p)
    {
        Console.WriteLine(Name + " consulted " + p.Name);
    }
}

class Hospital
{
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }

    public Hospital()
    {
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
    }
}

class Program
{
    static void Main()
    {
        Hospital h = new Hospital();
        Doctor d = new Doctor { Name = "Dr X" };
        Patient p = new Patient { Name = "John" };
        h.Doctors.Add(d);
        h.Patients.Add(p);
        d.Consult(p);
    }
}
