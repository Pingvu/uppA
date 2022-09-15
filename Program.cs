// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

internal class program{

 private static void main(string[] args){

Console.WriteLine("triangle or rektangle?");
string shape = Console.ReadLine();
Console.WriteLine("Write width and height: ");
int width = int.Parse((Console.ReadLine()));
int height = int.Parse((Console.ReadLine()));
if (shape=="triangle"){


Triangle triangle =new Triangle(width,height);
double triArea= triangle.Area();
double triOmkr= triangle.Omkr();
Console.WriteLine(triArea);
Console.WriteLine(triOmkr);
}
else if (shape== "rektangle"){
    Rektangle rektangle = new Rektangle (width,height);
    double rekArea= rektangle.Area();
double rekOmkr= rektangle.Omkr();
Console.WriteLine(rekArea);
Console.WriteLine(rekOmkr);
}
else{
    Console.WriteLine("Please write only rektangle or triangle.");
}
}
}
  
   