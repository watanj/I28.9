using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace it28
{
    internal class Dice
    {

        public int Value;
        
      

        public Dice()
        {
        }
            

        public void Roll( Random rng)
        {
            
                 
                 Value = rng.Next(1,7 );

           
           
        }
        
    }
}
