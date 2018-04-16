using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrainGrow2._0
{
    class Logic
    {
        IList<Cell> allCellScreenList;
        IList<int> workIdCellList;
        IList<int> cellIdToDrawList;
        IList<Color> colorList;
        Graphics drawArea;
        int xWidth, yWidth;
        int NumberOfCell;
        Boolean limes;
        int neighborhood;  // 1-von neuman 2-moore 3 - heksagonal left hekst right

        public Logic()
        {
            allCellScreenList = new List<Cell>();
            workIdCellList= new List<int>();
            cellIdToDrawList = new List<int>();
            colorList = new List<Color>();
        }

        public void addRandomGrain(int numberOfGrain)
        {
            int counter = 0;
            Random rnd = new Random();
            do
            {
                int z = rnd.Next(0, NumberOfCell);
                if (allCellScreenList.ElementAt(z).getIsDraw() == false)
                {
                    drawCorlor(z);
                    drawCell(z);
                    allCellScreenList.ElementAt(z).setIsDraw(true);
                    counter++;
                    addToWorkList(z);
                }
            }
            while (counter != numberOfGrain);            
        }
        
        public void addMouseGrain(int x,int y)
        {
                    
            int pomX = x - x % 5;
            int pomY = y- y % 5;
            int id = searchCell(pomX, pomY);
            if (id != -1)
            {
                drawCorlor(id);
                drawCell(id);
                addToWorkList(id);
                allCellScreenList.ElementAt(id).setIsDraw(true);
            }

        }

        private void addToWorkList(int number)
        {
            Boolean boundary = true;
            foreach(int i in workIdCellList)
            {
                if(number==i)
                {
                    boundary = false;
                    break;
                }
            }
            if(boundary)
            {
                workIdCellList.Add(number);
            }
        }

        private void addToMainList(int number,Color color)
        {
            if(allCellScreenList.ElementAt(number).getIsDraw()== false)
            {
                allCellScreenList.ElementAt(number).setColor(color);
                drawCell(number);
                allCellScreenList.ElementAt(number).setIsDraw(true);
            }
        }
                
        public void calculate()
        {
            switch( neighborhood)
            {
                case 1:
                    controlerVonNouman();
                    break;
                case 2:
                    controlerMoore();
                    break;
                case 3:
                    controlerHeksagonalLeft();
                    break;
                case 4:
                    controlerHeksagonalRight();
                    break;
            }
        }

        public Boolean checkCell(int number, IList<int> worklist)
        {
            Boolean result1 = false;
            Boolean result2 = true;
            Boolean finalResult = false;

            IList<int> neighboorList = allCellScreenList.ElementAt(number).getNeighborList();
            foreach(int index in neighboorList)
            {
                if (allCellScreenList.ElementAt(index).getIsDraw() == false) 
                result1 = true;
            }
            foreach(int  index in worklist)
            {
                if (index == number)
                    result2 = false;
            }
            if (result1 && result2)
                finalResult = true;
            return finalResult;
        }

        public void clear()
        {
            allCellScreenList.Clear();
            workIdCellList.Clear();
            cellIdToDrawList.Clear();
            colorList.Clear();
        }

        public void createCellList(int widthX,int widthY)
        {

            int x = widthX/5; 
            int y = widthY/5; 
            xWidth = x;yWidth = y;
            int counter = 0;
            int xStart = (600 - widthX)/ 2;
            int yStart = (600 - widthY)/ 2;
            for (int i=0;i<x;i++)
            {
                for(int j=0;j<y;j++)
                {
                    Cell help = new Cell(counter);
                    int xcell =xStart+(i*5); 
                    int ycell=yStart+(j*5);  
                    help.setX(xcell);
                    help.setY(ycell);
                    allCellScreenList.Add(help);
                    counter++;
                }
            }
            NumberOfCell = x * y;
        }

        private void drawCell(int id)
        {
            Cell helpCell = allCellScreenList.ElementAt(id);
            if (allCellScreenList.ElementAt(id).getIsDraw() == false)
            {
                Brush brush = new SolidBrush(helpCell.getColor());
                drawArea.FillRectangle(brush, helpCell.getX(), helpCell.getY(), 5,5);
            }
        }

        private void drawCorlor(int id)
        {
            Color newColor = new Color();
            Boolean boundary;
            do
             {
                boundary = false;
                Random rnd = new Random();
                int r = rnd.Next(0, 254);
                int g = rnd.Next(0, 254);
                int b = rnd.Next(0, 254);
                newColor = Color.FromArgb(r, g, b);
                foreach(Color color1 in colorList)
                {
                    if (color1.Equals(newColor))
                    {
                        boundary = true;
                        break;
                    }
                }
             }
            while (boundary);
            colorList.Add(newColor);
            allCellScreenList.ElementAt(id).setColor(newColor);
        }

        public void removeGrain(int x, int y)
        {
            int pomX = x - x % 5;
            int pomY = y - y % 5;
            int id = searchCell(pomX, pomY);
            if (id != -1)
            {
                Brush brush = new SolidBrush(Color.White);
                drawArea.FillRectangle(brush, pomX, pomY, 5, 5);
            }
        }

       
        private int searchCell(int x, int y)
        {
            foreach(Cell pom in allCellScreenList)
            {
                if (pom.getX() == x && pom.getY() == y)
                    return pom.getID();
            }
            return -1;
        }

        public void setDrawArea(Graphics area) => drawArea = area;
              
        public void setLimes(string text)
        {
            if (text.Equals("Perodic"))
            {
                limes = false;
            }
            else
            {
                limes = true; 
            }
        }
              
        public void setNeighborhood(string text)
        {
            if (text.Equals("Von neuman"))
            {
                neighborhood = 1;
            }
            else if (text.Equals("Moore"))
            {
                neighborhood = 2;
            }
            else if (text.Equals("Heksagonal Left"))
            {
                neighborhood = 3;
            }
            else
            {
                neighborhood = 4;
            }
        }
        
        public void TimeStep()
        {
            IList<int> helpList = new List<int>();
            foreach(int index in workIdCellList)
            {
                Color colorCell = allCellScreenList.ElementAt(index).getColor();
                IList<int> neighborLister = allCellScreenList.ElementAt(index).getNeighborList();
                foreach(int index2 in neighborLister)
                {
                    addToMainList(index2,colorCell);
                    Boolean checkResult= checkCell(index2, helpList);
                    if (checkResult)
                        helpList.Add(index2);
                }
            }
            workIdCellList.Clear();
            foreach(int index in helpList)
            {
                workIdCellList.Add(index);
            }
        }

        private void controlerVonNouman()
        {
            // 2 4 5 7
         foreach(Cell onecell in allCellScreenList)
            {
                onecell.clearList();
                neighborhoodSecond(onecell.getID());
                neighborhoodFourth(onecell.getID());
                neighborhoodFiveth(onecell.getID());
                neighborhoodSeventh(onecell.getID());
            }
         }

        private void controlerMoore()
        {
            //1-8
            foreach (Cell onecell in allCellScreenList)
            {
                onecell.clearList();
                neighborhoodFirst(onecell.getID());
                neighborhoodSecond(onecell.getID());
                neighborhoodThrid(onecell.getID());
                neighborhoodFourth(onecell.getID());
                neighborhoodFiveth(onecell.getID());
                neighborhoodSixth(onecell.getID());
                neighborhoodSeventh(onecell.getID());
                neighborhoodEigth(onecell.getID());
            }
             
           
        }
        private void controlerHeksagonalLeft()
        {
            // 1 ,2 4 5 7 8
            foreach (Cell onecell in allCellScreenList)
            {
                onecell.clearList();
                neighborhoodFirst(onecell.getID());
                neighborhoodSecond(onecell.getID());
                neighborhoodFourth(onecell.getID());
                neighborhoodFiveth(onecell.getID());
                neighborhoodSeventh(onecell.getID());
                neighborhoodEigth(onecell.getID());
           }
          
        }
        private void controlerHeksagonalRight()
        {
            // 2 3  4 5 6 7
            foreach (Cell onecell in allCellScreenList)
            {
                onecell.clearList();
                neighborhoodSecond(onecell.getID());
                neighborhoodThrid(onecell.getID());
                neighborhoodFourth(onecell.getID());
                neighborhoodFiveth(onecell.getID());
                neighborhoodSixth(onecell.getID());
                neighborhoodSeventh(onecell.getID());
           } 

       }
        private void neighborhoodFirst(int number)
        {
            if (limes)
            {
                int neigh = number - yWidth - 1;
                if (neigh >= 0 && neigh % yWidth != yWidth - 1)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
            }
            else
            {
                int neigh = number - yWidth - 1;
                if (neigh >= 0 && neigh % yWidth != yWidth - 1)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
                else
                {
                    if (number >= yWidth)
                    {
                        int neight2 = number - 1;
                        if (neight2 > 0)
                        {
                            allCellScreenList.ElementAt(number).addNeighbor(neight2);
                        }
                    }
                    else
                    {
                        if (number % yWidth == 0)
                        {
                            int neight2 = number + (xWidth * yWidth) - 1;
                            allCellScreenList.ElementAt(number).addNeighbor(neight2);

                        }
                        else
                        {
                            int neiht2 = number +((xWidth-1)*yWidth)-1;
                            allCellScreenList.ElementAt(number).addNeighbor(neiht2);
                        }
                    }
                }
            }
            
        }
        private void neighborhoodSecond(int number)
        {
            if (limes)
            {
                int neigh = number - 1;
                if (neigh >= 0 && neigh % yWidth != yWidth - 1)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
            }
            else
            {
                int neigh = number - 1;
                if (neigh >= 0 && neigh % yWidth != yWidth - 1)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
                else
                {
                    int neigh2 = number + yWidth - 1;
                    if (neigh2 < (xWidth * yWidth))
                        allCellScreenList.ElementAt(number).addNeighbor(neigh2);
                }
            }
            
        }
        private void neighborhoodThrid(int number)
        {
            if (limes)
            {
                int neigh = number + yWidth - 1;
                if (neigh < (xWidth * yWidth) && neigh % yWidth != yWidth - 1)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
            }
            else
            {
                int neigh = number + yWidth - 1;
                if (neigh < (xWidth * yWidth) && neigh % yWidth != yWidth - 1)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
                else
                {
                    if (number < yWidth*(xWidth-1))
                    {
                        int neight2 = number +(2*yWidth)-1;
                        if (neight2 < xWidth*yWidth)
                        {
                            allCellScreenList.ElementAt(number).addNeighbor(neight2);
                        }
                     }
                     else
                     {
                        if (number % yWidth == 0)
                        {
                            int neight2 = yWidth - 1;
                            allCellScreenList.ElementAt(number).addNeighbor(neight2);
                        }
                        else
                        {
                            int neiht2 = number - ((xWidth - 1) * yWidth) - 1;
                            allCellScreenList.ElementAt(number).addNeighbor(neiht2);
                        }
                     }
                   
                }
            }
            
        }
        private void neighborhoodFourth(int number)
        {
            if (limes)
            {
                int neigh = number - yWidth;
                if (neigh > 0)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
            }
            else
            {

                int neigh = number - yWidth;
                if (neigh > 0)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
                else
                {
                    int neigh2 = number + (yWidth * (xWidth - 1));
                    if(neigh2<(xWidth*yWidth))
                        allCellScreenList.ElementAt(number).addNeighbor(neigh2);
                }
            }
        }
        private void neighborhoodFiveth(int number)
        {
            if (limes)
            {
                int neigh = number + yWidth;
                if (neigh < (xWidth * yWidth))
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
            }
            else
            {
                int neigh = number + yWidth;
                if (neigh < (xWidth * yWidth))
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
                else
                {
                   int neigh2= number-(yWidth * (xWidth - 1));
                    if(neigh2>=0)
                        allCellScreenList.ElementAt(number).addNeighbor(neigh2);

                }
            }
         
        }
        private void  neighborhoodSixth(int number)
        {
            if (limes)
            {
                int neigh = number - yWidth + 1;
                if (neigh >= 0 && neigh % yWidth != 0)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
            }
            else
            {
                int neigh = number - yWidth + 1;
                if (neigh >= 0 && neigh % yWidth != 0)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
                else
                {
                    if (number >= yWidth)
                    {
                        int neight2 = number - (2*yWidth)+1;
                        if (neight2 > 0)
                        {
                            allCellScreenList.ElementAt(number).addNeighbor(neight2);
                        }
                    }
                    else
                    {
                        if (number % yWidth == yWidth-1)
                        {
                            int neight2 = number + ((xWidth-2) * yWidth) + 1;
                            allCellScreenList.ElementAt(number).addNeighbor(neight2);

                        }
                        else
                        {
                            int neiht2 = number + ((xWidth - 1) * yWidth) + 1;
                            allCellScreenList.ElementAt(number).addNeighbor(neiht2);
                        }
                    }
                }
            }
        }
        private void neighborhoodSeventh(int number)
        {
            if (limes)
            {
                int neigh = number + 1;
                if (neigh < (xWidth * yWidth) && neigh % yWidth != 0)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
            }
            else
            {
                int neigh = number + 1;
                if (neigh < (xWidth * yWidth) && neigh % yWidth != 0)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
                else
                {
                    int neigh2 = number - yWidth + 1;
                    if (neigh2 >=0)
                        allCellScreenList.ElementAt(number).addNeighbor(neigh2);
                }
            }

           
        }
        private void neighborhoodEigth(int number)
        {
            if (limes)
            {
                int neigh = number + yWidth + 1;
                if (neigh < (xWidth * yWidth) && neigh % yWidth != 0)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
            }
            else
            {
                int neigh = number + yWidth + 1;
                if (neigh < (xWidth * yWidth) && neigh % yWidth != 0)
                {
                    allCellScreenList.ElementAt(number).addNeighbor(neigh);
                }
                else
                {
                    if (number < yWidth * (xWidth - 1))
                    {
                        int neight2 = number + 1;
                        if (neight2 < xWidth * yWidth)
                        {
                            allCellScreenList.ElementAt(number).addNeighbor(neight2);
                        }
                    }
                    else
                    {
                        if (number % yWidth == yWidth -1)
                        {
                            int neight2 = 0;
                            allCellScreenList.ElementAt(number).addNeighbor(neight2);
                        }
                        else
                        {
                            int neiht2 = number - ((xWidth - 1) * yWidth) + 1;
                            allCellScreenList.ElementAt(number).addNeighbor(neiht2);
                        }
                    }
                }
            }
        }

       
    }
}
