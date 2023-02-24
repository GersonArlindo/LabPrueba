// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using BankConsole;

User Arlindo = new User(1, "Arlindo Gonzalez", "arlindo@gmail.com", 4000);
Arlindo.SetBalance(2000);

// Arlindo.ID = 1;
// Arlindo.Name = "Arlindo Gonzalez";
// Arlindo.Email = "arlindo@gmail.com";
// //Arlindo.Balance = 1000;
// Arlindo.RegisterDate = DateTime.Now;

Console.WriteLine(Arlindo.ShowData());

//Objeto 2
User Gerson = new User(2, "Gerson", "gerson@gmail.com", 3000);
//Console.WriteLine(Gerson.ShowData());
