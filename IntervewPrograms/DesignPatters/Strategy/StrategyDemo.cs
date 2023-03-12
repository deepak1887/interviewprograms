namespace DesignPatters.Strategy;
public class StrategyDemo
{
    public static void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            IChoice choice;
            var context = new Context();
            if (i%2 == 0)
            {
                choice = new FirstChoice();
            }
            else
            {
                choice= new SecondChoice();
            }
            context.SetChoice(choice);
            context.ShowChoice();
        }
    }
}
