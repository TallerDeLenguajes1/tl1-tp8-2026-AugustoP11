namespace EspacioTarea;

public class Tarea
{
    private int tareaID;
    private string descripcion;
    private int duracion; //Entre 10 y 100

    public int TareaID { get => tareaID; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    public Tarea(int tarea, string descripcion, int duracion)
    {
        this.tareaID = tarea;
        this.descripcion = descripcion;
        this.duracion = duracion;
    }
}