using exercise67.Models;

Student carlos = new Student("Carlos", "Eduardo", new DateTime(2003, 7, 15), new List<double> { 10, 9.8, 5.0, 7.0});
Student ana = new Student("Ana", "Clara", new DateTime(2004, 12, 1), new List<double> { 5, 4, 10, 10});
Student roberto = new Student("Roberto", "Silva", new DateTime(2002, 4, 4), new List<double> { 10, 10, 9.9, 2.0});
Teacher gustavo = new Teacher("Gustavo", "Fernando");

Discipline discipline = new Discipline("Mathematics");

gustavo.AddDiscipline(discipline);
gustavo.ShowDisciplines();

discipline.AddStudent(carlos);
discipline.AddStudent(ana);
discipline.AddStudent(roberto);
discipline.ShowStudents();
