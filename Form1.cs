using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrainGrow2._0
{
    public partial class Form1 : Form
    {
        Graphics drawArea;
        int sizeX=600;
        int sizeY=600;
        int xStart = 0;
        int yStart = 0;
        Logic controler;
        Boolean windowsOption = false;
        Boolean boundary = false;
        Boolean neighboor = false;
        public Form1()
        {
            InitializeComponent();
            drawArea = pictureBox1.CreateGraphics();
            controler = new Logic();
            controler.setDrawArea(drawArea);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeGenerateBox.GetItemText(TypeGenerateBox.SelectedItem).Equals("Random"))
            {
                NumberGainLabel.Visible = true;
                NumberGainBox.Visible = true;
                GenerateButton.Visible = true;
            }
            if (TypeGenerateBox.GetItemText(TypeGenerateBox.SelectedItem).Equals("By clicking"))
            {
                NumberGainLabel.Visible = false;
                NumberGainBox.Visible = false;
                GenerateButton.Visible = false;
            }
         }

        private void SetButton_Click(object sender, EventArgs e)
        {
            sizeX = (int)NumericSizeX.Value;
            sizeY = (int)NumericSizeY.Value;
            xStart = (600 - sizeX) / 2;
            yStart = (600 - sizeY) / 2;
            pictureBox1.Enabled = true;
            ReDrawArea();
            controler.createCellList(sizeX, sizeY);
            windowsOption = true;
            CheckButton();
            SetButton.Enabled = false;
            TypeGenerateBox.Enabled = true;
            controler.calculate();
           
           GenerateButton.Enabled = true;
        }

        private void EixitButton_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }
        private void ReDrawArea()
        {
            Color backend = new Color();
            backend = Color.FromArgb(192, 255, 255);
            drawArea.Clear(backend);
            Brush brush = new SolidBrush(Color.White);
            drawArea.FillRectangle(brush,xStart,yStart,sizeX,sizeY);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReDrawArea();
            SetButton.Enabled = true;
            TypeGenerateBox.Enabled = false;
            controler.clear();
            pictureBox1.Enabled = false;
            GenerateButton.Enabled = false;
         }

        private void CheckButton()
        {
            if (windowsOption && boundary && neighboor)
                StartButon.Enabled = true;
        }

        private void BundaryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controler.setLimes(BundaryBox.GetItemText(BundaryBox.SelectedItem));
            boundary = true;
            CheckButton();
            controler.calculate();
        }

        private void NeighborhoodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controler.setNeighborhood(NeighborhoodBox.GetItemText(NeighborhoodBox.SelectedItem));
            neighboor = true;
            CheckButton();
            controler.calculate();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (!(NumberGainBox.Text.Equals(String.Empty)))
            {
                int z = int.Parse(NumberGainBox.Text);
                if (z > 50 || z<=0)
                    MessageBox.Show("The number of grain shold be between 1 to 50");
                else
                {
                    controler.addRandomGrain(z);
                }
            }
            else
            {
                MessageBox.Show("Field can't be empty");
                
            }
            GenerateButton.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs event1 = (MouseEventArgs)e;
            if (event1.X>=xStart && event1.Y>=yStart && event1.X <= xStart+sizeX && event1.Y <= yStart+sizeY)
            {
                if (event1.Button == MouseButtons.Right)
                {
                    controler.removeGrain(event1.X, event1.Y);
                }
                if (event1.Button == MouseButtons.Left && TypeGenerateBox.GetItemText(TypeGenerateBox.SelectedItem).Equals("By clicking"))
                {
                    controler.addMouseGrain(event1.X, event1.Y);
                }
            }
        }

        private void StartButon_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void StopButon_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controler.TimeStep();
        }
    }
}
