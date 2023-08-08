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
            Console.WriteLine(Clientes[0]);
    }

}

