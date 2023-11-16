using System;


namespace levelup
{
    public class Character
    {
        string name;
        static string DEFAULT_NAME="ATARI";
        Position currPos;
        public Character()
        {
            currPos=new Position(0,0);
            name=DEFAULT_NAME;
        }   
        public Character(string name) 
        {
            this.name=name;
            currPos=new Position(0,0);
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