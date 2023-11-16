using System.Drawing;

namespace levelup {
    public class Position {

        Point coordinates;
        public Position(int xCoordinates, int yCoordinates) {
            coordinates = new Point(xCoordinates, yCoordinates);
        }
    }
}