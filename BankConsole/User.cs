using Newtonsoft.Json;
namespace BankConsole;

public class User 
{
    //Propiedades de la clase
    [JsonProperty]
    protected int  ID{get; set;}
     [JsonProperty]
    protected string Name { get; set; }
     [JsonProperty]
    protected string Email { get; set; }
     [JsonProperty]
    protected decimal Balance { get; set; }
     [JsonProperty]
    protected DateTime RegisterDate { get; set; }

    public User(){}

    //Metodo de la clase

    public virtual void SetBalance(decimal amount){
        decimal quantity = 0;
        if(amount < 0){
            quantity = 0;
        }else{
            quantity = amount;
        }

        this.Balance += quantity;
    }

    public virtual string ShowData(){
         return  $"ID: {this.ID}, Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de Registro: {this.RegisterDate.ToShortDateString()}.";
    }

    public string ShowData(string initialMessage){
         return  $"{initialMessage} -> Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de Registro: {this.RegisterDate}.";
    }


    //Nuevo constructor con parametros
    public User(int ID, string Name, string Email, decimal Balance){
        this.ID = ID;
        this.Name = Name;
        this.Email = Email;
        this.RegisterDate = DateTime.Now;
    }

    public DateTime GetRegisterDate(){
        return RegisterDate;
    }
}