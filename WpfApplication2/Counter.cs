//Authors: Charles Clayton and Robert Rayburn
//Last date modified: December 1, 2016
//File name: Counter.cs
//Description: Contains the class that has the variables for the number of attempted
//             and number of correct answers.
//Note: All documentation is in readme.

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
