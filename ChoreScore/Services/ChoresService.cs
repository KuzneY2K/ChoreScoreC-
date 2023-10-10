using ChoreScore.Models;

namespace ChoreScore.Services;

public class ChoresService
{
    private readonly ChoresRepository _choresRepo;

    public ChoresService(ChoresRepository choresRepo)
    {
        _choresRepo = choresRepo;
    }

    internal List<Chore> GetChores()
    {
        List<Chore> chores = _choresRepo.GetAllChores();
        return chores;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _choresRepo.CreateChore(choreData);
        return chore;
    }
}