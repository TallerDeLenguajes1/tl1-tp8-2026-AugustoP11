using EspacioOperacion;
using EspacioTipoOperacion;
namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;

    public double Dato{get => dato; set => dato = value;}

    public List<Operacion> Historial = new List<Operacion>();

    public Calculadora()
    {
        dato = 0;
    }

    public double Resultado{get => dato;}

    public void Limpiar()
    {
        dato = 0;
        Historial.Clear();
        Console.WriteLine("Memoria limpiada con exito!");
    }

    public void Sumar(double termino)
    {
        double aux = dato;
        dato += termino;
        Historial.Add(new Operacion(aux, dato, TipoOperacion.Suma)); 
    }

    public void Restar(double termino)
    {
        double aux = dato;
        dato -= termino;
        Historial.Add(new Operacion(aux, dato, TipoOperacion.Resta));
    }

    public void Multiplicar(double termino)
    {
        double aux = dato;
        dato *= termino;
        Historial.Add(new Operacion(aux, dato, TipoOperacion.Multiplicacion));
    }

    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            double aux = dato;
            dato /= termino;
            Historial.Add(new Operacion(aux, dato, TipoOperacion.Division));
        } else
        {
            Console.WriteLine("No se puede dividir por 0!");
        }
    }
}