// Refactor the following class using best practices for organizing straight-line code:

public class Chef
{
    public void Cook()
    {
        Potato potato = this.GetPotato();
        Carrot carrot = this.GetCarrot();

        this.Peel(potato);
        this.Peel(carrot);

        this.Cut(potato);
        this.Cut(carrot);

        Bowl bowl;
        bowl = this.GetBowl();
        bowl.Add(carrot); 
        bowl.Add(potato);
    }

    private Bowl GetBowl()
    {
        // ... 
    }

    private Potato GetPotato()
    {
        // ...
    }

    private Carrot GetCarrot()
    {
        // ...
    }

    private void Cut(Vegetable potato)
    {
        // ...
    }
}
