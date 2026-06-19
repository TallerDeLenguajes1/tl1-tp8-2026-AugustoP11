using EspacioTarea;


Random aleatorio = new Random();
//Genero de 2 a 5 tareas
int numeroDeTareas = aleatorio.Next(2,6);

//ID de las tareas
int contadorID = 0, duracionTarea;

//Descripcion
string descripcionTarea;

List<Tarea> tareasPendientes = new List<Tarea>();

//Carga de tareas a la lista de tareas pendientes
for (int i = 0; i < numeroDeTareas; i++)
{
    //Solicito que se ingrese la descripcion de la tarea
    Console.WriteLine("Ingrese la descripcion de la tarea:");
    descripcionTarea = Console.ReadLine();

    //Duracion de la tarea
    do
    {
        duracionTarea = aleatorio.Next(0, 200);
        
    } while (duracionTarea < 10 || duracionTarea > 100);

    tareasPendientes.Add(new Tarea(contadorID, descripcionTarea, duracionTarea));
}

