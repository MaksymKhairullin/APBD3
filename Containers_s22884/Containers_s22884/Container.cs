namespace Containers_s22884;

public class Container
{
    public static int counter = 1;
    public int WeightOfTheLoad { get; set; }
    public int MaxWeightOfTheLoad{ get;}
    public int Height{ get;}
    public int OwnWeight{ get;}
    
    public int Depth{ get;}
    public string SerialNumber{ get; set; }
    public string ContainerType{ get; set; }
    public int NumOfContainer = 1;

    public Container(int weightOfTheLoad, int maxWeightOfTheLoad, int height, int ownWeight,string containerType)
    {
        WeightOfTheLoad = weightOfTheLoad;
        MaxWeightOfTheLoad = maxWeightOfTheLoad;
        Height = height;
        OwnWeight = ownWeight;
        ContainerType = containerType;
        GenerateSerialNumber();
    }


    public virtual string GenerateSerialNumber()
    {
        counter = NumOfContainer;
        string str = $"KON--{Counter}";

        SerialNumber = str;
        return str;
    }

    public static int Counter
    {
        get { return counter++; }
    }

    public virtual void Load(int payLoad)
    {
        {
            if (payLoad > MaxWeightOfTheLoad)
            {
                throw new OverFillException();
            }

            WeightOfTheLoad = payLoad;
        }
    }

    public  virtual void Unload()
    {
        WeightOfTheLoad = 0;
    }

    public override string ToString()
    {
        return $"{WeightOfTheLoad} {MaxWeightOfTheLoad} {Height} {SerialNumber} {OwnWeight} {ContainerType} ";
    }
}