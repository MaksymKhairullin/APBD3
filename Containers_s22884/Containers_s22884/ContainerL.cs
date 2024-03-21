namespace Containers_s22884;

public class ContainerL :Container,IHazardNotifier
{
    private static int counter = 1;

    public ContainerL(int weightOfTheLoad, int maxWeightOfTheLoad, int height, int ownWeight,string containerType)
        : base(weightOfTheLoad, maxWeightOfTheLoad, height, ownWeight,containerType)
    { }

    public static int Counter
    {
        get { return counter++;}
    }


    public override string GenerateSerialNumber()
    {
        
        string str = $"KON-{ContainerType}-{Counter}";
        NumOfContainer = counter;
        
        SerialNumber = str;
        return str;
    }

    public override void Load(int payLoad)
    {
        if (payLoad > MaxWeightOfTheLoad * 0.5)
        {
            throw new InvalidOperationException("Dangerous cargo can be filled up to 50% of capacity."); 
            
        }
        payLoad = (int)(payLoad * 0.9);
        base.Load(payLoad);
    }

    public void HazardMessage(Container container)
    {
        Console.WriteLine("Dangerous message for: " + container.SerialNumber + container.NumOfContainer);
    }
}

public interface IHazardNotifier
{
    void HazardMessage(Container container);
    
}