namespace Taller.Clases;

public class Empleado:Persona{

    public string Especialidad { get; set; }

    public Empleado(int Cc,string Nombre,string Apellido,long Telefono,string Email,string Especialidad): base(Cc,Nombre,Apellido,Telefono, Email){
        this.Especialidad = Especialidad;
    }

}