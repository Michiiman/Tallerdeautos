namespace Taller.Clases;

public class Cliente : Persona {

    public string FechaRegistro { get; set; }

    public List<Vehiculos> Vehiculos {get;set;}
    
    public Cliente(int Cc,string Nombre,string Apellido,long Telefono,string Email, string FechaRegistro): base (Cc,Nombre,Apellido,Telefono, Email){
        this.FechaRegistro=FechaRegistro;
        this.Vehiculos = new List<Vehiculos>();
    }
    public Cliente(){}

    public AgregarVehiculo(){
        
    }
}