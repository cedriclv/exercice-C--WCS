using System;

public class BeerCompany
{
    public static void Main(string[] args)
    {
        BeerEncapsulator beerEncapsulator = new BeerEncapsulator();

        Console.Write("Litres de bière disponibles :");
        beerEncapsulator.setAvalaibleBeerVolume(int.Parse(Console.ReadLine()));
        Console.WriteLine("------------------------------");

        Console.Write("Bouteilles vides disponibles :");
        beerEncapsulator.setAvalaibleBottles(int.Parse(Console.ReadLine()));
        Console.WriteLine("------------------------------");

        Console.Write("Capsules disponibles :");
        beerEncapsulator.setAvalaibleCapsules(int.Parse(Console.ReadLine()));
        Console.WriteLine("------------------------------");

        Console.Write("Bouteilles à remplir :");
        int nbBottlesDone = beerEncapsulator.ProduceEncapsulatedBeerBottles(int.Parse(Console.ReadLine()));
        Console.WriteLine("------------------------------");
        Console.WriteLine("Vous avez pu produire " + nbBottlesDone + "bouteilles");
        Console.WriteLine("------------------------------");

    }
}

public class BeerEncapsulator
{
    public String errors;
    public decimal _avalaibleBeerVolume;
    public int _avalaibleBottles = 100;
    public int _avalaibleCapsules = 50;
    public BeerEncapsulator()
    {

    }

    public void AddBeer(decimal volumeAdded)
    {
        _avalaibleBeerVolume = _avalaibleBeerVolume + volumeAdded;
    }
    public int ProduceEncapsulatedBeerBottles(int bottlesNeeded)
    {
        int bottlesDone = 0;

        // Calcul du manque
        int bottlesMissing = 0;
        decimal beerMissing = 0m;
        int capsulesMissing = 0;
        int capsulesNeeded = bottlesNeeded;
        decimal beerNeeded = 0.33m * bottlesNeeded;

        if( (this.getAvalaibleBottles() - bottlesNeeded) < 0 ){
            bottlesMissing = Math.Abs(this.getAvalaibleBottles() - bottlesNeeded);
            Console.WriteLine("il manque "+ bottlesMissing + " bouteilles");
        } 
        if( (this.getAvalaibleCapsules() - capsulesNeeded) < 0 ){
            capsulesMissing = Math.Abs(this.getAvalaibleCapsules() - capsulesNeeded);
            Console.WriteLine("il manque "+ capsulesMissing + " capsules");
        } 
        if( (this.getAvalaibleBeerVolume() - beerNeeded) < 0m ){
            beerMissing = Math.Abs(this.getAvalaibleBeerVolume() - beerNeeded);
            Console.WriteLine("il manque "+ beerMissing + " litres de biere");
        } 


        bool quantityOk = true;
        for (int i = 0; i < bottlesNeeded; i++)
        {
            while (bottlesDone < bottlesNeeded && quantityOk)
            {
                // faire les checks de quantité si une est manquante la mettre dans le tableau errors
                if (this.getAvalaibleBeerVolume() < 0.33M)
                {
                    quantityOk = false;
                }
                if (this.getAvalaibleBottles() < 1)
                {
                    quantityOk = false;
                }
                if (this.getAvalaibleCapsules() < 1)
                {
                    quantityOk = false;
                }
                if (quantityOk)
                {
                    this.setAvalaibleBeerVolume(this.getAvalaibleBeerVolume() - 0.33M);
                    this.setAvalaibleBottles(this.getAvalaibleBottles() - 1);
                    this.setAvalaibleCapsules(this.getAvalaibleCapsules() - 1);
                    bottlesDone++;
                }
            }

        }
        return bottlesDone;
    }
    public decimal getAvalaibleBeerVolume()
    {
        return _avalaibleBeerVolume;
    }
    public void setAvalaibleBeerVolume(decimal avalaibleBeerVolume)
    {
        _avalaibleBeerVolume = Math.Abs(avalaibleBeerVolume);
    }
    public int getAvalaibleBottles()
    {
        return _avalaibleBottles;
    }
    public void setAvalaibleBottles(int avalaibleBottles)
    {
        _avalaibleBottles = Math.Abs(avalaibleBottles);
    }
    public int getAvalaibleCapsules()
    {
        return _avalaibleCapsules;
    }
    public void setAvalaibleCapsules(int avalaibleCapsules)
    {
        _avalaibleCapsules = Math.Abs(avalaibleCapsules);
    }

}