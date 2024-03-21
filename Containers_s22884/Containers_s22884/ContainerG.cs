namespace Containers_s22884;

public class ContainerG:Container,IHazardNotifier
{
    private static int counter = 1;
    
    public ContainerG(int weightOfTheLoad, int maxWeightOfTheLoad, int height, int ownWeight, string containerType) 
        : base(weightOfTheLoad, maxWeightOfTheLoad, height, ownWeight, containerType)
    {
    }
    
    public static int Counter
    {
        get { return counter++; }
    }

    
    public override string GenerateSerialNumber()
    {
        string str = $"KON-{ContainerType}-{Counter}";
        NumOfContainer = counter;

        SerialNumber = str;
        return str;
    }

    
    public override void Unload()
    {
        WeightOfTheLoad = (int)(MaxWeightOfTheLoad * 0.05);
    }

    public void HazardMessage(Container container)
    {
        Console.WriteLine("Danger message for: " + container.SerialNumber);
    }

    
}