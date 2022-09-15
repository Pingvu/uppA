using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppA;
     class Rektangle: shape
    {
         public Rektangle(int width, int height): base(width,height){
             
         }
         public double Area (){
            return  width*height;
         }
         public double Omkr(){
            return width*2 + height*2;
         }
    }
