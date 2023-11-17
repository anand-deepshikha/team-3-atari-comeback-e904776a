using System.Drawing;
using System.Reflection.Metadata.Ecma335;
namespace levelup {
    public class GameMap {
        int numPositions;
        Position startingPosition;
        Position [,]positions;
        Position currentPosition;
        Position newPosition = new Position(0,0);

     public GameMap()
     {
          numPositions = 100;
          startingPosition=new Position(0,0);
          positions=new Position[10,10];
          for(int x=0;x<10;x++)
          {
            for (int y=0;y<10;y++)
            {
               //Position p=new Position(x,y);
               positions[x,y]=new Position(x,y);
               positions[x,y].Y=y;
               positions[x,y].X=x;
               Console.WriteLine("Position[{0},{1}]={2},{3}",x,y,positions[x,y].X,positions[x,y].Y);
            }
          }
         startingPosition=positions[0,0];
     }
        public int getTotalPositions {get { return numPositions; }}

      public Position GetCurrentPosition() {
         return currentPosition;
      }
      public Position GetNewPosition() {
         return newPosition;
      }


      public void calculatePosition(Position startingPostion,GameController.DIRECTION ditrection)
      {
         Console.WriteLine("START");
         Console.WriteLine("startingPosition = " + startingPosition.X + ", " + startingPosition.Y);
         //currentPosition = startingPosition;
         //onsole.WriteLine("currentPosition = " + currentPosition.X + ", " + currentPosition.Y);               
         if (ditrection == GameController.DIRECTION.NORTH) {
            
            if (isPositionValid(startingPostion)) {
               newPosition.X = startingPosition.X;
               newPosition.Y = startingPosition.Y + 1;
               //Console.WriteLine("newPosition = " + newPosition.X + ", " + newPosition.Y);
            }
            else if(ditrection == GameController.DIRECTION.SOUTH)
            {
               newPosition.X = startingPosition.X;
               newPosition.Y = startingPosition.Y - 1;
            }
            else if(ditrection == GameController.DIRECTION.EAST)
            {
               newPosition.X = startingPosition.X+1;
               newPosition.Y = startingPosition.Y;
            }
            else if(ditrection == GameController.DIRECTION.WEST)
            {
               newPosition.X = startingPosition.X-1;
               newPosition.Y = startingPosition.Y;
            }
            Console.WriteLine("newPosition = " + newPosition.X + ", " + newPosition.Y);
         }

         Console.WriteLine("END");
      }
        public bool isPositionValid(Position point) {
        if (point.X >= 0 && point.X <= 9 )
        {
            if (point.Y >= 0 && point.Y <= 9 )
            {
             return true;
            }
        }
        return false;
        }

   }
}