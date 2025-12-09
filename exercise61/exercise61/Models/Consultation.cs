namespace exercise61.Models;

public class Consultation
{
    public string PatientName { get; set; }
    public string DoctorName { get; set; }
    public DateTime ConsultationDate { get; set; }
    public bool Rescheduled { get; set; }

    public Consultation(string patientName, string doctorName, DateTime consultationDate)
    {
        PatientName = patientName;
        DoctorName = doctorName;
        ConsultationDate = consultationDate;
        Rescheduled = false;
    }

    public void Reschedule(DateTime newDate)
    {
        ConsultationDate = newDate;
        Rescheduled = true;
    }

    public void DisplayConsultation()
    {
        if (Rescheduled)
        {
            Console.WriteLine($"Appointment scheduled with {DoctorName} for patient {PatientName}.");
            Console.WriteLine($"New date: {ConsultationDate.ToString("dd/MM/yyyy")}");
            return;
        }
        Console.WriteLine($"Appointment scheduled with {DoctorName} for patient {PatientName}.");
        Console.WriteLine($"Date: {ConsultationDate.ToString("dd/MM/yyyy")}");
    }
}
