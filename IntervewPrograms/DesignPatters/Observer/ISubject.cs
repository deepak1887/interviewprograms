namespace DesignPatters.Observer;
public interface ISubject
{
    void Subscribe(IObserver o);
    void UnSubscribe(IObserver o);
    void Notify(int i);
}
