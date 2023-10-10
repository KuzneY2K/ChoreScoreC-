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

    internal Chore GetChore(Guid choreId)
    {
        Chore chore = _choresRepo.GetChore(choreId);
        if (chore == null)
        {
            throw new Exception($"No {choreId} found!");
        }
        return chore;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _choresRepo.CreateChore(choreData);
        return chore;
    }

    internal string RemoveChore(Guid choreId)
    {
        Chore chore = this.GetChore(choreId);
        _choresRepo.RemoveChore(choreId);
        return $"{choreId} was removed!";
    }
}