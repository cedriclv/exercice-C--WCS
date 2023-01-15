//Ta mission est de prévoir un nombre d'étages suffisant en fonction de la hauteur du bâtiment.
//Et, afin de fidéliser tes clients, tu veux leur proposer un programme qui le fait tout seul.
//Il n'y a pas de limite concernant les interactions avec l'utilisateur. Essaie cependant de faire
// en sorte que les interactions soient les plus claires possible.
using System;

public class BuildingWorkOut
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Combien d'etages voulez vous ?");
        int nbOfLevelRequested = int.Parse(Console.ReadLine());
        Console.WriteLine("Voulez vous partir sur une hauteur standard de 3 metres par etage ?");
        String input = Console.ReadLine();
        if (input.Equals("Y"))
        {
            Building batiment = new Building(nbOfLevelRequested);
            Console.WriteLine("La hauteur du batiment est de " + batiment.GetSize() + " metres");
        }
        else
        {
            Console.WriteLine("Dans ce cas, on prends combien pour la taille totale du batiment ?");
            float buildingHeightRequested = float.Parse(Console.ReadLine());
            Building batiment = new Building(nbOfLevelRequested, buildingHeightRequested);
            Console.WriteLine("La hauteur du batiment est de " + batiment.GetSize() + " metres avec " + batiment.GetFloorCount() + " etages faisant " + batiment.GetFloorMaxSize() + " metres chacun");
        }
    }
}

public class Building
{

    private float _buildingHeight;
    private int _nbOfLevel;

    public Building(int nbOfLevel)
    {
        _buildingHeight = nbOfLevel * 3;
    }
    public Building(int nbOfLevel, float buildingHeight)
    {
        _buildingHeight = buildingHeight;
        _nbOfLevel = nbOfLevel;
    }

    public float GetFloorMaxSize()
    {
        return _buildingHeight / _nbOfLevel;

    }
    public int GetFloorCount()
    {
        return _nbOfLevel;

    }
    public float GetSize()
    {
        return _buildingHeight;

    }
}