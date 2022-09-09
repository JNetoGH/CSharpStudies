namespace Company;

class OutsourcedEmployee : Employee
{
    public double AdditionalCharge { get; set; }
    
    public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour) 
    {
        AdditionalCharge = additionalCharge;
    }

    public sealed override double Payment() 
    {
        double basePayment = base.Payment();
        double bonus = AdditionalCharge + (AdditionalCharge * 0.1); // 110%
        return basePayment + bonus;
    }
}