using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


     class Rektangle: shape
    {
         public Rektangle(int width, int height): base(width,height){
             
         }
         public override int Area (){
            return  width*height;
         }
         public override int Omkr(){
            return width*2 + height*2;
         }
    }
