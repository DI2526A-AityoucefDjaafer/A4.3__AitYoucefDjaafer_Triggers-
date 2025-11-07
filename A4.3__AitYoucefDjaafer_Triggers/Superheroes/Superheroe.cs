using CommunityToolkit.Mvvm.ComponentModel;

public class Superheroe : ObservableObject
{
    private string _nombre;
    public string Nombre
    {
        get => _nombre;
        set => SetProperty(ref _nombre, value);
    }

    private string _imagenRuta;
    public string ImagenRuta
    {
        get => _imagenRuta;
        set => SetProperty(ref _imagenRuta, value);
    }

    private bool _vengador;
    public bool Vengador
    {
        get => _vengador;
        set => SetProperty(ref _vengador, value);
    }

    private bool _xmen;
    public bool Xmen
    {
        get => _xmen;
        set => SetProperty(ref _xmen, value);
    }

    private bool _heroe;
    public bool Heroe
    {
        get => _heroe;
        set => SetProperty(ref _heroe, value);
    }

    public Superheroe()
    {
        Nombre = "";
        ImagenRuta = "";
        Vengador = false;
        Xmen = false;
        Heroe = true;
    }

    public Superheroe(string nombre, string imagenRuta, bool vengador, bool xmen, bool heroe)
    {
        Nombre = nombre;
        ImagenRuta = imagenRuta;
        Vengador = vengador;
        Xmen = xmen;
        Heroe = heroe;
    }
}