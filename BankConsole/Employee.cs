namespace BankConsole;

public class Employee : User, Iperson
{
    public string Departament { get; set; }

    public Employee(){}
    public Employee(int ID, string Name, string Email, decimal Balance, string Departament) : base(ID, Name, Email, Balance)
    {
        this.Departament = Departament;
        SetBalance(Balance);
    }

    public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);

            if(Departament.Equals("IT"))
            Balance += (amount * 0.05m);
          
    }

    public override string ShowData()
    {
        return base.ShowData() + $", Departamento: {this.Departament}";
    }

    string Iperson.GetName()
    {
        return Name + "!";
    }

    string Iperson.GetCountry()
    {
        throw new NotImplementedException();
    }
}