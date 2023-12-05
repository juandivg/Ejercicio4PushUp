// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;




Universidad u =new Universidad();
List<Universidad> universidades=new List<Universidad>();
u.IngresarDatos(universidades);


public class Universidad{
    public string Nombre;
    public List<string>  Votos=new List<string>();
    public Universidad(){}
    public void MostrarDatos(List<Universidad> u)
{
    System.Console.WriteLine("Numero de universidades");
        System.Console.WriteLine(u.Count());
        int a;
        int r;
        int b;
        int n;
        int x=0;
        int y=0;
        int z=0;
    for(int i=0;i< u.Count();i++)
    {
        a=0;
        b=0;
        r=0;
        n=0;
      
        System.Console.WriteLine("Universidad: "+u[i].Nombre);
        int m= u[i].Votos.Count();
        for(int j=0;j<m;j++)
        {

            System.Console.WriteLine("Voto: "+ u[i].Votos[j]);
            if(u[i].Votos[j]=="A")
            {
                a++;
            }
            else if(u[i].Votos[j]=="R")
            {
                r++;
            }
            else if(u[i].Votos[j]=="N")
            {
                n++;
            }
            else if(u[i].Votos[j]=="B")
            {
                b++;
            }
            

        }
        System.Console.WriteLine(u[i].Nombre + " "+ a +" aceptan "+ r +" rechazan "+ b +" blancos "+ n +" nulos");
        if(a>r)
        {
            x++;
        }
        else if(r>a)
        {
            y++;
        }
        else if(a==r)
        {
            z++;
        }
    }
    System.Console.WriteLine( "Universidades que aceptan: "+ x);
    System.Console.WriteLine( "Universidades que rechazan: "+ y);
    System.Console.WriteLine( "Universidades que empatan: "+ z);

}
public void IngresarDatos(List<Universidad> universidades)
{
    
    System.Console.WriteLine("Ingrese la cantidad de universidades");

       int cantidad=int.Parse(Console.ReadLine());

    for(int i=0;i<cantidad;i++)
    {
        Universidad u =new Universidad();
        System.Console.WriteLine("Ingrese el nombre de la universidad ");
        u.Nombre=Console.ReadLine();
        string voto;
        do{
            System.Console.WriteLine("Ingrese el voto ");
            voto=Console.ReadLine();
            u.Votos.Add(voto);
        } while(voto!= "X");
        universidades.Add(u);
    }
    MostrarDatos(universidades);
}
}








 
 
