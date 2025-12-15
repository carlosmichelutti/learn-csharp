using exercise83.Models;

ContactList agenda = new ContactList("Marina Souza");

agenda.AddContact(new Contact("Carlos", "11998887777"));
agenda.AddContact(new Contact("Carlos", "11991112222"));
agenda.AddContact(new Contact("Julia", "21988776655"));

agenda.DisplayContacts();
