using Containers_s22884;

class Program
{

    static void Main(string[] args)
    {
        ContainerL containerL1 = new ContainerL(200,250,300,800,"L");
        ContainerL containerL2 = new ContainerL(200,250,300,350,"L");
        ContainerG containerG1 = new ContainerG(200,250,300,350,"G");
        ContainerG containerG2 = new ContainerG(200,250,300,350,"G");
        ContainerC containerC1 = new ContainerC(300, 500, 240, 430, "C", "Bananas", 11);
        ContainerC containerC2 = new ContainerC(300, 600, 120, 200, "C", "Meat", -15);
        
        //containerG2.Load(200);
        Ship ship = new Ship(200,7,1500);
        
        //containerC1.
        
        //containerG1.Unload();
        var tempContainer = containerC1.WeightOfTheLoad;
        Console.WriteLine(tempContainer);
        //containerL1.Load(100);
        //var containerL1WeightOfTheLoad = containerL1.WeightOfTheLoad;
        //Console.WriteLine(containerL1WeightOfTheLoad);

        //List<Container> _list = new List<Container>() { containerL1, containerG1, containerC1 };
        //ship.LoadContainersFromList(_list);
        //ship.InfoAboutShip();
        // Console.WriteLine(containerL1.ToString());
        // Console.WriteLine(containerL2.ToString());
        // Console.WriteLine(containerG1.ToString());
        // Console.WriteLine(containerG2.ToString());
        // Console.WriteLine(containerC1.ToString());
        // Console.WriteLine(containerC2.ToString());
    } 

    
}