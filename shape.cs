
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 class shape 
   { 
    protected int width;
    protected int height;
        
     public shape(int width, int height){
        this.width = width;
        this.height=height;
     }
     public virtual int Area (){
         return 0;
     }
     public virtual int Omkr(){
              return 0;
     }
     
   }