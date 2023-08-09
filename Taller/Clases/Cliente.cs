namespace Taller.Clases;

public class Cliente : Persona {

    public string FechaRegistro { get; set; }

    public List<Vehiculo> Vehiculo { get; set; }
    
    public Cliente(int Cc,string Nombre,string Apellido,long Telefono,string Email, string FechaRegistro,List<Vehiculo> vehiculo): base (Cc,Nombre,Apellido,Telefono, Email){
        this.FechaRegistro=FechaRegistro;
        this.Vehiculo= vehiculo;
        
    }
    public Cliente(){}

}