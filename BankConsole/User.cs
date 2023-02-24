namespace BankConsole;

public class User{
    //Propiedades de la clase
    private int  ID{get; set;}
    private string Name { get; set; }
    private string Email { get; set; }
    private decimal Balance { get; set; }
    private DateTime RegisterDate { get; set; }

    //Metodo de la clase

    public void SetBalance(decimal Balance){
        if(Balance < 0){
            this.Balance = 0;
        }else{
            this.Balance = Balance;
        }
    }
    public string ShowData(){
         return  $"Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de Registro: {this.RegisterDate}.";
    }

    //Nuevo constructor sin parametros
    public User(){
        this.Balance = 2000;
    }
    //Nuevo constructor con parametros
    public User(int ID, string Name, string Email, decimal Balance){
        this.ID = ID;
        this.Name = Name;
        this.Email = Email;
        this.Balance = Balance;
        this.RegisterDate = DateTime.Now;
    }
}