namespace Containers_s22884;

public class Ship
{
    private List<Container> _list;
    private int MaxSpeed;
    private int MaxNumOfContainers;
    private int SumWeight;
    private int TempWeight;
    private int MaxWeightAllContainers;

    public Ship( int maxSpeed, int maxNumOfContainers, int maxWeightAllContainers)
    {
        _list = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxNumOfContainers = maxNumOfContainers;
        MaxWeightAllContainers = maxWeightAllContainers;
    }

    public void LoadContainer(Container container)
    {
        if (_list.Count >= MaxNumOfContainers)
        {
            throw new Exception("We can not have more containers then: " + MaxNumOfContainers);
        }
        _list.Add(container);
    }

    public void LoadContainersFromList(List<Container> list)
    {
        if (list.Count>= MaxNumOfContainers)
        {
            throw new Exception("We can not have more containers then: " + MaxNumOfContainers);
        }

        foreach (var variablContainer in  list)
        {
             SumWeight = variablContainer.OwnWeight;
             TempWeight =TempWeight + SumWeight;
        }

        if (TempWeight < MaxWeightAllContainers)
        {
            foreach (var ist in list)
            {
                _list.Add(ist);
            }
        }
        else
        {
            Console.WriteLine("Weight your containers more then max weight for this ship");
        }


    }

    public void DeleteContainer(Container container)
    {
        if (_list.Count > 0)
        {
            _list.Remove(container);
        }

    }

    public void ReplaceContainer(Container container, int NumOfContainer)
    {
        var ContainerToReplace = _list.Find(c => c.NumOfContainer == NumOfContainer);
        if (ContainerToReplace!=null)
        {
            int index = _list.IndexOf(ContainerToReplace);
            _list[index] = container;
        }
        else
        {
            throw new Exception("We can't find container with this number");
        }

    }

    public void TransferContainerBetweenTwoShips(Container container,Ship ship)
    {
        DeleteContainer(container);
        ship.LoadContainer(container);
        
    }

    public void InfoAboutContainer(Container container)
    {
        Console.WriteLine($"Serial Number of container {container.SerialNumber}");
        Console.WriteLine($"Type of container {container.ContainerType.ToString()}");
        Console.WriteLine($"Own Weight of container {container.OwnWeight}");
        
    }

    public void InfoAboutShip()
    {
        Console.WriteLine($"Max speed: {MaxSpeed}");
        Console.WriteLine($"Max num of containers: {MaxNumOfContainers}");
        Console.WriteLine($"Max weight for all containers: {MaxWeightAllContainers}");

        foreach (var container in _list)
        {
            InfoAboutContainer(container);
            
        }
        
    }




}