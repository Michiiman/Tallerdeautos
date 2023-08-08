using Taller.View;
using Taller.Clases;

internal class Program
{
    
    private static void Main(string[] args)
    {
        TallerAutomotriz  taller= new();
        Menu menu = new();
        int opcion;
        do {
            menu.menu();
            Console.Write("Seleccione el modulo a ingresar: ");
            opcion=int.Parse(Console.ReadLine());
            switch(opcion) {
                case 1:
                    MenuClientes menuClint=new();
                    int opcionClientes;
                    do {
                        menuClint.Menu();
                        Console.Write("Seleccione la opcion que necesita: ");
                        opcionClientes=int.Parse(Console.ReadLine());
                        switch (opcionClientes) {
                            case 1:
                                taller.AgregarCliente();
                                break;
                            case 2:
                                taller.MostrarClientes(); 
                                break;  
                            case 3:
                            case 4:
                                break;
                            default:
                                break;
                        }
                    }while(opcionClientes!=4);
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    break;
                default:
                    break;
            }
        }while(opcion!=6);


    }
}
