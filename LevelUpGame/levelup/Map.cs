using System.Drawing;
using System.Reflection.Metadata.Ecma335;
namespace levelup {
    public class Map {
        int numPositions = 100;

        public int positions {get { return numPositions; }}

        public bool isPositionValid(Point point) {

        if (point.X > 0 && point.X < 9 )
        {
             return true ;
        }
        if (point.Y > 0 && point.Y < 9 )
        {
             return true ;
        }
        return false;
        }
   }
}