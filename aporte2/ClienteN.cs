public class ClienteN
{
    public string dispositivos {get; set;}

    public string IMEI {get; set;}

    public string marca {get;set;}

    public string modelo {get;set;}
    public string so{get;set;}

    public ClienteN (string dispositivos, string IMEI, string marca, string  modelo, string so)
    {
        this.dispositivos = dispositivos;
        this.IMEI=IMEI;
        this.marca=marca;
        this.modelo= modelo;
        this.so=so;
    }
}