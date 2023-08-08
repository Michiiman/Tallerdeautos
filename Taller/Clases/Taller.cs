namespace Taller.Clases;


public class TallerAutomotriz{

    private List<Cliente> Clientes = new List<Cliente>();


    public void AgregarCliente(){
        
        Console.WriteLine("Agregar Nuevo Cliente");
        Console.Write("Ingrese la cedula del cliente: ");
        int Cc=int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del cliente: ");
        string Nombre=Console.ReadLine();
        Console.Write("Ingrese el Apellido del cliente: ");
        string Apellido=Console.ReadLine();
        Console.Write("Ingrese el Telefono del cliente: ");
        long Telefono=long.Parse(Console.ReadLine());
        Console.Write("Ingrese el Email del cliente: ");
        string Email=Console.ReadLine();
        string FechaRegistro= DateTime.Now.ToString("");
        
        Cliente cliente = new Cliente(Cc,Nombre,Apellido,Telefono,Email,FechaRegistro);
        Clientes.Add(cliente);
    }

    public void MostrarClientes(){
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("*********************************************Clientes*****************************************************");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|   Cedula   |     Nombres   |   Apellidos   | Telefono |           Email            |      Registro     |");
            foreach(var cliente in Clientes)
            {
                Console.WriteLine(String.Format("|{0,-12}|{1,-15}|{2,-15}|{3,-10}|{4,-28}|{5,-19}|", cliente.Cc,cliente.Nombre,cliente.Apellido,cliente.Telefono,cliente.Email,cliente.FechaRegistro));
                Console.WriteLine("----------------------------------------------------------------------------------------------------------");           
            }
                Console.ReadLine();
    }

}

