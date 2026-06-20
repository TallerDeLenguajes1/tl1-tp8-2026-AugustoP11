using EspacioTarea;


Random aleatorio = new Random();
//Genero de 2 a 5 tareas
int numeroDeTareas = aleatorio.Next(2,6);

//ID de las tareas
int contadorID = 0, duracionTarea;

//Descripcion
string descripcionTarea;

//Creo las listas de tareas
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

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

    contadorID++;
}


//_______________________________________________________________
//_______INTERFAZ PARA MOVER TAREAS PENDIENTES A REALIZADAS______
//_______________________________________________________________

int opcion, id;
do
{
    Console.WriteLine("Ingrese '1' para marcar una tarea como realizada mediante ID");
    Console.WriteLine("Ingrese '0' para salir");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 0:
        break;

        case 1:
            do
            {
                Console.WriteLine("\nIngrese un ID de tarea valido:");
                id = int.Parse(Console.ReadLine());
            } while (id < 0 || id > numeroDeTareas);

            foreach (var tarea in tareasPendientes)
            {
                if (id == tarea.TareaID)
                {
                    tareasRealizadas.Add(tarea);
                    tareasPendientes.Remove(tarea);
                    break;
                }
            }
        break;

        default:
        break;
    }

} while (opcion != 0);
