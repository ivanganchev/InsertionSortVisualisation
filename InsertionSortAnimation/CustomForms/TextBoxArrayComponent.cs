using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace InsertionSortAnimation.CustomForms
{
    class TextBoxArrayComponent : TextBox
    {
        private int number;
        private bool downFlag;
        public TextBoxArrayComponent(int number)
        {
            this.Multiline = true;
            this.Width = 50;
            this.Height = 50;
            this.AutoSize = true;
            this.BackColor = Color.CadetBlue;
            this.Font = new Font("Arial", 9);
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReadOnly = true;
            
            this.number = number;
        }

        public int getNumber()
        {
            return this.number;
        }

        public bool isDown()
        {
            return this.downFlag;
        }

        public void setDownFlag(bool val)
        {
            this.downFlag = val;
        }

        public void MoveDown()
        {
            for(int i = 0; i < 20; i++)
            {
                Thread.Sleep(50);
                this.Location = new Point(this.Location.X, this.Location.Y + 5);
            }
             
        }
        
        public void MoveUp()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(50);
                this.Location = new Point(this.Location.X, this.Location.Y - 5);
            }
        }

        public void MoveLeft()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                this.Location = new Point(this.Location.X - 5, this.Location.Y);
            }
        }

        public void MoveRight()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                this.Location = new Point(this.Location.X + 5, this.Location.Y);
            }
        }

        
    }
}
