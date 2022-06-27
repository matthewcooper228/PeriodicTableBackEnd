using Models;
namespace DataLayer;
public class StaticStorage
{
    public static List<Element> Elements {get; set;} = new List<Element>(){
        new Element {
            AtomicNumber = 1,
            Symbol = "H",
            Name = "hydrogen",
            ImageURL = "",
            MolarMass = 1.008,
            Electronegativity = 2.20,
            IonizationEnergy = 13.598,
            AtomicRadius = 0.0
        }
    };
}
