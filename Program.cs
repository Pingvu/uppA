// See https://aka.ms/new-console-template for more information
using System;

   class shape 
   { 
    protected int width = Int32.Parse(Console.ReadLine());
    protected int height = Int32.Parse(Console.ReadLine()) ;
        
     public shape(int width, int height){
        this.width = width;
        this.height=height;
     }
     
   }
   