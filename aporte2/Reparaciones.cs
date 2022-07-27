    public class Reparaciones: IDisposable
    {
               private readonly List<IObserver<ClienteN>> observers;



        private readonly IObserver<ClienteN> observer;

    public Reparaciones( List<IObserver<ClienteN>> observers, IObserver<ClienteN> observer)
    {
            this.observers = observers;
            this.observer = observer;

    }

    public void Dispose()
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }