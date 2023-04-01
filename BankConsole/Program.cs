// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using BankConsole;

if(args.Length == 0){
    EmailService.SendMail();
}else{
    Console.WriteLine("Tercer Argumento: " + args[2]);
}

// Client ana = new Client(3, "Ana", "ana@gmail.com", 1500, 'M');
// StorageJson.AddUser(ana);






