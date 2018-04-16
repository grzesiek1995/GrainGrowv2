using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrainGrow2._0
{
    class Cell
    {
        int Id;
        IList<int> neighborList;
        Color cellColor;
        Boolean isDraw;
        int x, y;
        public Cell(int id)
        {
            Id = id;
            isDraw = false;
            neighborList = new List<int>();
            
        }
        public int getID() => Id;

        public Color getColor() => cellColor;

        public void setColor(Color color) => cellColor = color;

        public void setIsDraw(Boolean newflag) => isDraw = newflag;

        public Boolean getIsDraw() => isDraw;

        public void addNeighbor(int index) => neighborList.Add(index);

        public IList<int> getNeighborList() => neighborList;

        public int getX() => x;

        public void setX(int x1) => x = x1;

        public int getY() => y;

        public void setY(int y1) => y = y1;

        public void clearList()=> neighborList.Clear();
    }
}
