    public class OrdenR : IObserver<ClienteN>
    {
        private IDisposable cancelacion;
        public string nombrecliente { get; set; }

        public List<ClienteN> dispositivos { get; set; }

        public OrdenR (string nombrecliente)
        {
            this.nombrecliente = nombrecliente;
            dispositivos = new ();
        }

        public virtual void Reparacion (DispoReparar proveedor)
        {
            cancelacion = reparar.Reparacion(this);
        }

        public virtual void Unsubcripcion ()
        {
            cancelacion.Dispose();
            dispositivos.Clear();
        }

        public void OnCompleted()
        {
            Console.WriteLine($"Bienvenido {nombrecliente} ya hemos arreglado tu dispositivo");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{nombrecliente} No sé pudo reparar el dispositivo {dispositivos} o tiene algun otro fallo de fabrica");
        }

        public void OnNext(ClienteN value)
        {
            dispositivos.Add(value);
        }
        public void ListaArreglados()
        {
            if(dispositivos.Any())
            {
                foreach(var dis in dispositivos)
                {
                    Console.WriteLine($"{ nombrecliente}! {dis.dispositivos} se acaba de cambiar a nuevas funcionalidades o hardware adicional {dis.so}");
                }
            }else {
                Console.WriteLine($"{nombrecliente}! ya no tienes mas reparaciones");
                }
            }
        }