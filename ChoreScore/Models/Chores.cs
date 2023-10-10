namespace ChoreScore.Models;

public class Chore
{
    public Guid Id { get; set; }
    public string ChoreName { get; set; }
    public bool Completed { get; set; }
    public string Tasker { get; set; }

    public Chore(Guid id, string choreName, bool complete, string tasker)
    {
        Id = id;
        ChoreName = choreName;
        Completed = complete;
        Tasker = tasker;
    }
}