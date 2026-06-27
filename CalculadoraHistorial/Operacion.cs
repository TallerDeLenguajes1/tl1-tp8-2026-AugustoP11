namespace EspacioOperacion;
using EspacioTipoOperacion;
using EspacioCalculadora;


public class Operacion
{
    private double resultadoAnterior; // Almacena el resultado previo al cálculo actual

    private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior

    private TipoOperacion operacion;// El tipo de operación realizada

    public double Resultado()
    {
        double resultado = 0;
        switch (operacion)
        {
            case TipoOperacion.Suma:
                resultado = resultadoAnterior + nuevoValor;
            break;

            case TipoOperacion.Resta:
                resultado = resultadoAnterior - nuevoValor;
            break;

            case TipoOperacion.Multiplicacion:
                resultado = resultadoAnterior * nuevoValor;
            break;

            case TipoOperacion.Division:
                resultado = resultadoAnterior / nuevoValor;
            break;

            default:
                Console.WriteLine("ERROR INESPERADO!");
            break;
        }
        return resultado;
    }

    // Propiedad pública para acceder al nuevo valor utilizado en la operación
    public double NuevoValor{get => nuevoValor;}

    // Constructor u otros métodos necesarios para inicializar y gestionar la operación
    // ...
    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }

}