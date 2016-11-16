using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class Counter
    {
        public int right, attempts;
        
        public Counter()
        {
            right = 0;
            attempts = 0;
        }

        public void updateBoth(){
            right++;
            attempts++;
        } 

        public void updateAttempt()
        {
            attempts++;
        }  
    }
}
