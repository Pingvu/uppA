// See https://aka.ms/new-console-template for more information


internal class program{

 private static void Main(){
 shape shape1;
 Console.WriteLine("triangle or rectangle?");
 string shape = Console.ReadLine();
 Console.WriteLine("Write width and height: ");
 int width = int.Parse((Console.ReadLine()));
 int height = int.Parse((Console.ReadLine()));
if (shape=="triangle"){
    shape1 =new Triangle(width,height);
    int triArea= (shape1 as Triangle).Area();
    int triOmkr= (shape1 as Triangle).Omkr();
    Console.WriteLine(triArea);
    Console.WriteLine(triOmkr);
}
else if (shape== "rectangle"){
    shape1 = new Rektangle (width,height);
    int rekArea= (shape1 as Rektangle).Area();
    int rekOmkr= (shape1 as Rektangle).Omkr();
    Console.WriteLine(rekArea);
    Console.WriteLine(rekOmkr);
}
else{
    Console.WriteLine("Please write either rectangle or triangle.");
}
}
}
  
   