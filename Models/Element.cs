namespace Models;
public class Element
{
    public int AtomicNumber {get; set; } = 0;
    public string Symbol {get; set;} = null!;
    public string Name {get; set;} = null!;
    public string ImageURL {get; set;} = null!;
    public double MolarMass {get; set;} = 0.0;
    public double Electronegativity {get; set;} = 0.0;
    public double IonizationEnergy {get; set;} = 0.0;
    public double AtomicRadius {get; set;} = 0.0;

}
