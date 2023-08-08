namespace Taller.Clases;

public class Cliente : Persona {

    public string FechaRegistro { get; set; }
    //public List<Vehiculos> vehiculos=new List<Vehiculos>();
    
    public Cliente(int Cc,string Nombre,string Apellido,long Telefono,string Email, string FechaRegistro): base (Cc,Nombre,Apellido,Telefono, Email){
        this.FechaRegistro=FechaRegistro;
    }
    public Cliente(){}
}