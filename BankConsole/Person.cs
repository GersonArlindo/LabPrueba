namespace BankConsole;

public abstract class Person

{
    public abstract string GetName();

    public string GetCountry(){
        return "El Salvador";
    }
    
}

public interface Iperson
{
    string GetName();
    string GetCountry();
}