using exercise61.Models;

Consultation consultation = new Consultation("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
consultation.DisplayConsultation();
consultation.Reschedule(new DateTime(2025, 5, 25));
consultation.DisplayConsultation();
