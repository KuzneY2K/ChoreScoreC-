using ChoreScore.Models;

namespace ChoreScore.Services;

public class PetsService
{
    private readonly PetsRepository _petsRepo;

    public PetsService(PetsRepository petsRepo)
    {
        _petsRepo = petsRepo;
    }
}