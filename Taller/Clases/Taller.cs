namespace Taller.Clases;


public class TallerAutomotriz{

    private List<Cliente> Clientes = new List<Cliente>();

    private List<Vehiculo> Vehiculos =new();

    private List<Empleado> Empleados= new();

 //Clientes
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
        
        AgregarVehiculo();
        
        Cliente cliente = new Cliente(Cc,Nombre,Apellido,Telefono,Email,FechaRegistro,Vehiculos);
        Clientes.Add(cliente);
    }

    public void MostrarClientes(){
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("*********************************************Clientes**********************************************************");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|   Cedula   |     Nombres   |   Apellidos   | Telefono |           Email            |         Registro       |");
            foreach(var cliente in Clientes)
            {
                Console.WriteLine(String.Format("|{0,-12}|{1,-15}|{2,-15}|{3,-10}|{4,-28}|{5,-25}|", cliente.Cc,cliente.Nombre,cliente.Apellido,cliente.Telefono,cliente.Email,cliente.FechaRegistro));
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");           
            }
                MostrarCarro();
                Console.ReadLine();
    }

    //Vehiculos
    public void AgregarVehiculo(){

        Console.WriteLine("-----Agregar Vehiculo-----");
        Console.Write("Ingrese la placa del carro: ");
        string placa=Console.ReadLine();
        Console.Write("Ingrese el modelo del carro: ");
        int modelo=int.Parse(Console.ReadLine());
        Console.Write("Ingrese la marca del carro: ");
        string marca=Console.ReadLine();
        Console.Write("Ingrese el color del carro: ");
        string color=Console.ReadLine();    
        Console.Write("Ingrese cuanto kilometraje tiene el carro: ");
        int km=int.Parse(Console.ReadLine());

        Vehiculo carro= new Vehiculo(placa,modelo,marca,color,km);
        Vehiculos.Add(carro);
    }

    public void MostrarCarro(){

        foreach(var carro in Vehiculos){
            Console.WriteLine(carro.Placa);
            Console.WriteLine(carro.Modelo);
            Console.WriteLine(carro.Marca);
            Console.WriteLine(carro.Color);
            Console.WriteLine(carro.Km);
        }
            //Console.ReadLine();
    }

    // Empleados    
    public void AgregarEmpleado(){
        Console.WriteLine("Agregar Nuevo Empleado");

        Console.Write("Ingrese la cedula del empleado: ");
        int Cc=int.Parse(Console.ReadLine());

        Console.Write("Ingrese el nombre del empleado: ");
        string Nombre=Console.ReadLine();

        Console.Write("Ingrese el Apellido del empleado: ");
        string Apellido=Console.ReadLine();

        Console.Write("Ingrese el Telefono del empleado: ");
        long Telefono=long.Parse(Console.ReadLine());

        Console.Write("Ingrese el Email del empleado: ");
        string Email=Console.ReadLine();

        Console.WriteLine("Ingrese la especialidad del empleado: ");
        string Especialidad=Console.ReadLine();

        Empleado empleado= new Empleado(Cc,Nombre,Apellido,Telefono,Email,Especialidad);
        Empleados.Add(empleado);
    }

    public void MostrarEmpleados(){
        Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("*******************************************Empleados***********************************************************");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|   Cedula   |     Nombres   |   Apellidos   | Telefono |           Email            |      Especialidad      |");
            foreach(var empleado in Empleados)
            {
                Console.WriteLine(String.Format("|{0,-12}|{1,-15}|{2,-15}|{3,-10}|{4,-28}|{5,-25}|", empleado.Cc,empleado.Nombre,empleado.Apellido,empleado.Telefono,empleado.Email,empleado.Especialidad));
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");           
            }
                Console.ReadLine();
    }

}


    
