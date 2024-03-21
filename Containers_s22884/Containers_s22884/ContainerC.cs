namespace Containers_s22884;

public class ContainerC:Container
{
    private static int counter = 1;
    public string TypeOfProduct;
    public int Temperature;
    
    
    public ContainerC(int weightOfTheLoad, int maxWeightOfTheLoad, int height, int ownWeight, string containerType,string typeOfProduct,int temperature) 
        : base(weightOfTheLoad, maxWeightOfTheLoad, height, ownWeight, containerType)
    {
        TypeOfProduct = typeOfProduct;
        Temperature = temperature;
        CheckTemperature();
        
    }
    
    public static int Counter
    {
        get { return counter++; }
    }

    public void CheckTemperature()
    {
        List<string> warmlist = new List<string>() { "Bananas", "Chocolate", "Butter", "Eggs" };
        List<string> coldlist = new List<string>() { "Fish", "Cheese", "Sausages"};
        List<string> colderlist = new List<string>() { "Meat", "Ice Cream", "Frozen Pizza"};
        
        if (Temperature <= 21 && Temperature >=10 && warmlist.Contains(TypeOfProduct))
        {
            Console.WriteLine("You are succesfully completed check on the temperature");
        }
        else if (Temperature <= 9 && Temperature >= 0 && coldlist.Contains(TypeOfProduct))
        {
            Console.WriteLine("You are succesfully completed check on the temperature");

        }
        else if (Temperature <= 0 && Temperature >= -30 && colderlist.Contains(TypeOfProduct))
        {
            Console.WriteLine("You are succesfully completed check on the temperature");
        }
        else
        {
            throw new Exception("You are not passed check on the temperature. " +
                                "Please type correct temperature" +
                                "Or you type not correct product :)");
        }
        
    }


    public override string GenerateSerialNumber()
    {
        //CheckTemperature();
        string str = $"KON-{ContainerType}-{Counter}";
        NumOfContainer = counter;
        

        SerialNumber = str;
        return str;
    }
}