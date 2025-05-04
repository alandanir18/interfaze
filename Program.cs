public interface IAvion
{
    void Volar();
    void Planear();
    void Aterrizar();
}

public class Gato : IAvion
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Gato(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void Volar()
    {
        Console.WriteLine("El gato no puede volar.");
    }

    public void Planear()
    {
        Console.WriteLine("El gato no puede planear.");
    }

    public void Aterrizar()
    {
        Console.WriteLine("El gato no aterriza, pero podría saltar.");
    }
}

public class Pez : IAvion
{
    public string Especie { get; set; }
    public int CantidadDeAletas { get; set; }

    public Pez(string especie, int cantidadDeAletas)
    {
        Especie = especie;
        CantidadDeAletas = cantidadDeAletas;
    }

    public void Volar()
    {
        Console.WriteLine("El pez no puede volar.");
    }

    public void Planear()
    {
        Console.WriteLine("El pez no puede planear.");
    }

    public void Aterrizar()
    {
        Console.WriteLine("El pez no aterriza.");
    }
}

public class Comida : IAvion
{
    public string Tipo { get; set; }
    public int Cantidad { get; set; }

    public Comida(string tipo, int cantidad)
    {
        Tipo = tipo;
        Cantidad = cantidad;
    }

    public void Volar()
    {
        Console.WriteLine("La comida no puede volar.");
    }

    public void Planear()
    {
        Console.WriteLine("La comida no puede planear.");
    }

    public void Aterrizar()
    {
        Console.WriteLine("La comida no aterriza.");
    }
}

public class Program
{
    public static void Main()
    {
        Gato gato = new Gato("Miau", 3);
        Pez pez = new Pez("Dorado", 4);
        Comida comida = new Comida("Pizza", 1);

        gato.Volar();
        gato.Planear();
        gato.Aterrizar();

        pez.Volar();
        pez.Planear();
        pez.Aterrizar();

        comida.Volar();
        comida.Planear();
        comida.Aterrizar();
    }
}
