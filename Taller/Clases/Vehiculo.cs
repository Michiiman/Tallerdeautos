namespace Taller.Clases;

public class Vehiculo{

    public string  Placa {get;set;}
    public int Modelo{get;set;}
    public string Marca {get;set;}
    public string Color {get;set;}
    public int Km {get;set;}

    public Vehiculo(string placa,int modelo,string marca,string color,int km){
        this.Placa=placa;
        this.Modelo=modelo;
        this.Marca=marca;
        this.Color=color;
        this.Km=km;
    }
    
    

}