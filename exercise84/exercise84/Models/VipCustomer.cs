namespace exercise84.Models;

internal class VipCustomer : Person
{
    public string Level { get; }
    public string VipCode { get; }

    public VipCustomer(string name, int age, string level, string vipCode)
        : base(name, age)
    {
        Level = level;
        VipCode = vipCode;
    }

    public override string ToString()
    {
        return $"Welcome, VIP customer: {Name}\nAge: {Age}\nLevel: {Level}\nVIP Code: {VipCode}\n";
    }
}
