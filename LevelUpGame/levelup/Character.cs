using System;


namespace levelup
{
    public class Character
    {
        string name;
        Position currPos;
        Character()
        {
            
        }   
        Character(string name) 
        {
            this.name=name;
        }
        string getName()
        {
            return this.name;
        }

        Position getPosition()
        {
          return currPos;
        }
        
        
    }
}