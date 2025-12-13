using exercise76.Models;

Email email = new Email();
email.SendNotification("testing email notification");

Sms sms = new Sms();
sms.SendNotification("testing SMS notifications");
