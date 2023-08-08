namespace Taller.Clases;
            
public class Persona {
    public int Cc{get;set;}
    public string Nombre {get;set;}
    public string Apellido{get;set;}
    public long Telefono {get;set;}
    public string Email {get;set;}


    public Persona (int Cc,string Nombre,string Apellido,long Telefono,string Email)
    {
        this.Cc = Cc;
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Telefono = Telefono;
        this.Email = Email;
    }
    public Persona(){}
}