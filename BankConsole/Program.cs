// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using BankConsole;

if(args.Length == 0)
    EmailService.SendMail();
else
    ShowMenu();
    //Console.WriteLine("Tercer Argumento: " + args[2]);

void ShowMenu(){
   Console.Clear();
   Console.WriteLine("Selecciona una opcion"); 
   Console.WriteLine("1 - Crear un Usuario nuevo.");
   Console.WriteLine("2 - Eliminar un usuario existente.");
   Console.WriteLine("3 - Salir.");

   int option = 0;
   do{
    string input = Console.ReadLine();

    if(!int.TryParse(input, out option))
        Console.WriteLine("Debes ingresar un numero (1, 2 o 3).");
    else if(option > 3)
        Console.WriteLine("Debes ingresar un numero valido (1, 2 o 3)");
   }while(option == 0 || option > 3);

   switch(option)
   {
    case 1:
        CreateUser();
        break;
    case 2:
        DeleteUser();
        break;
    case 3:
        Environment.Exit(0);
        break;
   }
}

void CreateUser(){
    Console.Clear();
    Console.WriteLine("Ingresa la informacion del usuario");

    Console.WriteLine("ID: ");
    int ID = int.Parse(Console.ReadLine());

    Console.WriteLine("Nombre: ");
    string name = Console.ReadLine();

    Console.WriteLine("Email: ");
    string email = Console.ReadLine();

    Console.WriteLine("Saldo: ");
    decimal balance = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Escribe 'c' si el usuario es Cliente, 'e' si es Empleado: ");
    char userType = char.Parse(Console.ReadLine());

    User newUser;

    if(userType.Equals('c')){
        Console.WriteLine("Regimen Fiscal: ");
        char taxRegime = char.Parse(Console.ReadLine());

        newUser = new Client(ID, name, email, balance, taxRegime);
    }else{
          Console.WriteLine("Departamento: ");
          string department = Console.ReadLine();

          newUser = new Employee(ID, name, email, balance, department);
    }

    StorageJson.AddUser(newUser);

    Console.WriteLine("Usuario Creado Exitosamente!");
    Thread.Sleep(2000);
    ShowMenu();

}

void DeleteUser(){

}

// Client ana = new Client(3, "Ana", "ana@gmail.com", 1500, 'M');
// StorageJson.AddUser(ana);






