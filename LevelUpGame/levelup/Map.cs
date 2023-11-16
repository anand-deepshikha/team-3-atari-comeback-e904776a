using System.Drawing;
using System.Reflection.Metadata.Ecma335;
namespace levelup {
    public class Map {
        int numPositions;
        Position startingPosition;
        Position [,]positions;

     public Map()
     {
          numPositions = 100;
          startingPosition=new Position(0,0);
          positions=new Position[10,10];
     }
        public int getTotalPositions {get { return numPositions; }}
     public void calculatePosition(Position startingPostion,GameController.DIRECTION ditrection)
     {

     }
        public bool isPositionValid(Point point) {
           
           
        if (point.X > 0 && point.X < 9 )
        {
            if (point.Y > 0 && point.Y < 9 )
            {
             return true;
            }
        }
        return false;
        }

   }
}