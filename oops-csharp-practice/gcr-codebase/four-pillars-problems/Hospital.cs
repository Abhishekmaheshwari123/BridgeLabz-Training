using System;
using System.Collections.Generic;

abstract class Patient
{
    private int patientId;
    private string name;
    private int age;
    private string diagnosis;

    public int PatientId
    {
        get { return patientId; }
        set { patientId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    protected string Diagnosis
    {
        get { return diagnosis; }
        set { diagnosis = value; }
    }

    public Patient(int id, string n, int a)
    {
        PatientId = id;
        Name = n;
        Age = a;
    }

    public abstract double CalculateBill();

    public string GetPatientDetails()
    {
        return "ID: " + PatientId + " Name: " + Name + " Age: " + Age;
    }
}

interface IMedicalRecord
{
    void AddRecord(string record);
    string ViewRecords();
}

class InPatient : Patient, IMedicalRecord
{
    private string history;

    public InPatient(int id, string n, int a) : base(id, n, a) { }

    public override double CalculateBill()
    {
        return 5000;
    }

    public void AddRecord(string record)
    {
        history = record;
    }

    public string ViewRecords()
    {
        return history;
    }
}

class OutPatient : Patient, IMedicalRecord
{
    private string history;

    public OutPatient(int id, string n, int a) : base(id, n, a) { }

    public override double CalculateBill()
    {
        return 500;
    }

    public void AddRecord(string record)
    {
        history = record;
    }

    public string ViewRecords()
    {
        return history;
    }
}

class Program7
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>();
        patients.Add(new InPatient(1, "A", 30));
        patients.Add(new OutPatient(2, "B", 25));

        foreach (Patient p in patients)
        {
            Console.WriteLine(p.GetPatientDetails());
            Console.WriteLine("Bill: " + p.CalculateBill());
        }
    }
}
