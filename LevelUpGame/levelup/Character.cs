using System;


namespace levelup
{
    public class Character
    {
        string name;
        static string DEFAULT_NAME="ATARI";
        Position currPos;
        Map map;
        public Character()
        {
            currPos=new Position(0,0);
            name=DEFAULT_NAME;
            map= new Map();
        }   
        public Character(string name) 
        {
            this.name=name;
            currPos=new Position(0,0);
        }
        public string getName()
        {
            return this.name;
        }

        public Position getPosition()
        {
          return currPos;
        }
        public void enterMap(Map map)
        {

        }
        public void move(GameController.DIRECTION direction)
        {
            
        }
    }
}