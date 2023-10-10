using ChoreScore.Models;

namespace ChoreScore.Repositories;

public class PetsRepository
{
    private List<Pet> _PetDb;

    public PetsRepository()
    {
        _PetDb = new List<Pet>();
    }

}