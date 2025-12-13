using exercise77.Models;

exercise77.Models.File file = new exercise77.Models.File("test.txt");
file.Save();
file.Restore();

Database database = new Database("database");
database.Save();
database.Restore();
