namespace DesignPatters.Strategy;
public class Context
{
    private IChoice? choice;

    public void SetChoice(IChoice choice)
    {
        this.choice = choice;
    }

    public void ShowChoice()
    {
        choice?.MyChoice();
    }
}
