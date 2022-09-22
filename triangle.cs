using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    class Triangle : shape
    {    
        
         public Triangle(int width, int height): base(width,height){
             
         }
         public override int Area (){
            return  width*height/2;
         }
         public override int Omkr(){
            return (int)Math.Sqrt(width*width + height*height) + width + height;
         }
        
    }
