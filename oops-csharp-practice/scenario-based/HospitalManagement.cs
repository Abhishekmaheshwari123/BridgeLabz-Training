using System;
using System.Collections.Generic;

public interface IPayable
{
    decimal CalculateBill();
}

public class Doctor
{
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public Doctor(int doctorId, string name, string specialization)
    {
        DoctorId = doctorId;
        Name = name;
        Specialization = specialization;
    }
}

public abstract class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Doctor AssignedDoctor { get; set; }

    protected Patient(int patientId, string name, int age, Doctor doctor)
    {
        PatientId = patientId;
        Name = name;
        Age = age;
        AssignedDoctor = doctor;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Patient ID : " + PatientId);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Age        : " + Age);
        Console.WriteLine("Doctor     : " + AssignedDoctor.Name + " (" + AssignedDoctor.Specialization + ")");
    }
}

public class InPatient : Patient, IPayable
{
    public int DaysAdmitted { get; set; }
    public decimal RoomChargePerDay { get; set; }

    public InPatient(int id, string name, int age, Doctor doctor, int days, decimal roomCharge)
        : base(id, name, age, doctor)
    {
        DaysAdmitted = days;
        RoomChargePerDay = roomCharge;
    }

    public decimal CalculateBill()
    {
        return DaysAdmitted * RoomChargePerDay;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type       : In-Patient");
        Console.WriteLine("Days       : " + DaysAdmitted);
        Console.WriteLine("Room/day   : " + RoomChargePerDay);
        Console.WriteLine("Bill       : " + CalculateBill());
    }
}

public class OutPatient : Patient, IPayable
{
    public decimal ConsultationFee { get; set; }

    public OutPatient(int id, string name, int age, Doctor doctor, decimal consultationFee)
        : base(id, name, age, doctor)
    {
        ConsultationFee = consultationFee;
    }

    public decimal CalculateBill()
    {
        return ConsultationFee;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type       : Out-Patient");
        Console.WriteLine("Consult    : " + ConsultationFee);
        Console.WriteLine("Bill       : " + CalculateBill());
    }
}

class Program
{
    static List<Patient> patients = new List<Patient>();

    static Doctor defaultDoctor = new Doctor(1, "Dr. Sharma", "General Physician");

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Hospital Menu =====");
            Console.WriteLine("1. Add In-Patient");
            Console.WriteLine("2. Add Out-Patient");
            Console.WriteLine("3. View All Patients");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddInPatient();
                    break;
                case 2:
                    AddOutPatient();
                    break;
                case 3:
                    ViewPatients();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }

    static void AddInPatient()
    {
        Console.Write("Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Days Admitted: ");
        int days = int.Parse(Console.ReadLine());

        Console.Write("Room Charge Per Day: ");
        decimal charge = decimal.Parse(Console.ReadLine());

        Patient p = new InPatient(id, name, age, defaultDoctor, days, charge);
        patients.Add(p);

        Console.WriteLine("In-Patient Added Successfully!");
    }

    static void AddOutPatient()
    {
        Console.Write("Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Consultation Fee: ");
        decimal fee = decimal.Parse(Console.ReadLine());

        Patient p = new OutPatient(id, name, age, defaultDoctor, fee);
        patients.Add(p);

        Console.WriteLine("Out-Patient Added Successfully!");
    }

    static void ViewPatients()
    {
        if (patients.Count == 0)
        {
            Console.WriteLine("No patients found.");
            return;
        }

        Console.WriteLine("\n--- Patient List ---");
        foreach (var p in patients)
        {
            Console.WriteLine("----------------------");
            p.DisplayInfo();
        }
    }
}
