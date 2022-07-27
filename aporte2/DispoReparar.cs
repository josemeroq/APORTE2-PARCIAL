   public class DispoReparar
    {
        private readonly List<IObserver<ClienteN>> observers;

        public List<ClienteN> dispositivoestado { get; set; }

        public DispoReparar()
        {
            observers = new();
            dispositivoestado = new();
        }

        public IDisposable (IObserver<ClienteN> observer)
        {
            if ( !observers.Contains(observer))
            {
                observers.Add(observer);
                foreach(var item in dispositivoestado)
                {
                    observer.OnNext(item);
                }
            }
            //return new Unsubcripcion(observers, observer);
        }
        public void TerminarReparacion()
        {
            foreach ( var observer in observers)
            {
                observer.OnCompleted();
            }
            observers.Clear();
        }
    }
}