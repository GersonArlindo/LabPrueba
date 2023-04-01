namespace BankConsole;

public class Client : User, Iperson
{
    public char TaxRegime { get; set; }

    public Client(){}

    public Client(int ID, string Name, string Email, decimal Balance, char TaxRegime) : base(ID, Name, Email, Balance)
    {
        this.TaxRegime = TaxRegime;
        SetBalance(Balance);
    }

    public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);

        if(TaxRegime.Equals('N'))
            Balance += (amount * 0.02m);
    }

    public override string ShowData()
    {
        return base.ShowData() + $", Regimen Fiscal: {this.TaxRegime}";
    }

    string Iperson.GetName()
    {
       return Name;
    }

    string Iperson.GetCountry()
    {
        throw new NotImplementedException();
    }
}