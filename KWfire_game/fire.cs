using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWfire_game
{
    public class fire
    {
        //object of the random class 
        Random rd = new Random();
        //user define method that is used to generate the sound of the fire 
        public int genNo(int frst,int last) {
            return rd.Next(frst, last);
        }


    }
}
