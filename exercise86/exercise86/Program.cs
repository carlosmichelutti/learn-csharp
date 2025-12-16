using exercise86.Models;

Analyst analista = new Analyst("Systems Analyst");
Teacher docente = new Teacher("Mathematics Teacher");
Certificate certificate1 = new Certificate(analista);
Certificate certificate2 = new Certificate(docente);

Console.WriteLine(certificate1);
Console.WriteLine(certificate2);
