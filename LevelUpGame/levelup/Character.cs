using System;


namespace levelup
{
    public class Character
    {
        string name;
        static string DEFAULT_NAME="ATARI";
        Position currPos;
        GameMap map;
        public Character()
        {
            currPos=new Position(0,0);
            name=DEFAULT_NAME;
            map= new GameMap();
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
        public void enterMap(GameMap map)
        {

        }
        public void move(GameController.DIRECTION direction)
        {
            
        }
    }
}