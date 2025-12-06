Consultation consultation = new Consultation("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
consultation.display_consultation();
consultation.reschedule(new DateTime(2025, 5, 25));
consultation.display_consultation();
