namespace ChoreScore.Models;

public class Pet
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }

    public Pet()
    {

    }

    public Pet(Guid id, string name, int age, string species, string breed)
    {
        Id = id;
        Name = name;
        Age = age;
        Species = species;
        Breed = breed;
    }

}