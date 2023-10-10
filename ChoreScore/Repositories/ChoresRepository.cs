using ChoreScore.Models;

namespace ChoreScore.Repositories;

public class ChoresRepository
{
    private List<Chore> _FakeDb;

    Guid id = Guid.NewGuid();

    public ChoresRepository()
    {
        _FakeDb = new List<Chore>();
        _FakeDb.Add(new Chore(id, "Clean", false, "Mark"));
        _FakeDb.Add(new Chore(id, "Do Dishes", false, "Mark"));
    }

    internal List<Chore> GetAllChores()
    {
        return _FakeDb;
    }

    internal Chore GetChore(Guid choreId)
    {
        Chore chore = _FakeDb.Find(c => c.Id == choreId);
        return chore;
    }

    internal Chore CreateChore(Chore choreData)
    {
        choreData.Id = id;
        _FakeDb.Add(choreData);
        return choreData;
    }


    internal void RemoveChore(Guid choreId)
    {
        Chore chore = _FakeDb.Find(c => c.Id == choreId);
        _FakeDb.Remove(chore);
    }
}