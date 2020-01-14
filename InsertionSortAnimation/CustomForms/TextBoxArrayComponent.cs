using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace InsertionSortAnimation.CustomForms
{
    class TextBoxArrayComponent : TextBox
    {
        public TextBoxArrayComponent()
        {
            this.Multiline = true;
            this.Width = 50;
            this.Height = 50;
            this.AutoSize = true;
            this.BackColor = Color.CadetBlue;
            this.Font = new Font("Arial", 9);
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReadOnly = true;
        }

        public void MoveDown(int x, int y)
        {
            this.Location = new Point(x, y - 5); 
        }
        
        public void MoveUp(int x, int y)
        {
            this.Location = new Point(x, y + 5);
        }

        public void MoveLeft(int x, int y)
        {
            this.Location = new Point(x - 5, y);
        }

        public void MoveRight(int x, int y)
        {
            this.Location = new Point(x + 5, y);
        }

        
    }
}
