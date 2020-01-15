using InsertionSortAnimation.CustomForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertionSortAnimation
{
    public partial class MainWindowForm : Form
    {
        List<TextBoxArrayComponent> numbersArray;
        TextBox arrayComponents;
        Label labelAboveBox;
        Button enterButton;
        Label sortedLabel;
        public MainWindowForm()
        {
            InitializeComponent();

        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            numbersArray = new List<TextBoxArrayComponent>();

            arrayComponents = new TextBox();
            arrayComponents.Location = new Point((this.Size.Width / 2) - (arrayComponents.Size.Width), 40);
            arrayComponents.Visible = false;

            labelAboveBox = new Label();
            labelAboveBox.Location = new Point((this.Size.Width / 2) - (arrayComponents.Size.Width), arrayComponents.Location.Y - arrayComponents.Size.Height);
            labelAboveBox.AutoSize = true;
            labelAboveBox.MaximumSize = new System.Drawing.Size(this.Size.Width, labelAboveBox.Size.Height);
            labelAboveBox.Text = "Enter array components.";
            labelAboveBox.Visible = false;

            enterButton = new Button();
            enterButton.Size = new Size(arrayComponents.Size.Width, arrayComponents.Size.Height);
            enterButton.Text = "Enter";
            enterButton.Location = new Point(arrayComponents.Location.X + arrayComponents.Size.Width, arrayComponents.Location.Y);          
            enterButton.Visible = false;
            
            sortedLabel = new Label();
            sortedLabel.Text = "Array is sorted!";
            sortedLabel.Location = new Point((this.Size.Width / 2) - (sortedLabel.Size.Width), this.Size.Height / 2);
            sortedLabel.AutoSize = true;
            sortedLabel.Font = new Font("Arial", 20);
            sortedLabel.Visible = false;

            this.Controls.Add(arrayComponents);
            this.Controls.Add(labelAboveBox);
            this.Controls.Add(enterButton);
            this.Controls.Add(sortedLabel);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.enterButton.Click += new EventHandler(this.enterButton_Click);
            this.StartButton.Hide();
            this.arrayComponents.Show();
            this.enterButton.Show();
            this.labelAboveBox.Show();
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            string[] numbers = arrayComponents.Text.Split(',').ToArray();
            int currentX = 0;
            //int spaceBetweenBoxes = 30;

            for(int i = 0; i < numbers.Length; i++)
            {
                TextBoxArrayComponent tbx = new TextBoxArrayComponent(Int32.Parse(numbers[i]));
                tbx.Text = numbers[i];
                currentX += tbx.Width;
                tbx.Location = new Point(currentX, tbx.Size.Height);
                this.Controls.Add(tbx);
                this.numbersArray.Add(tbx);
            }

            arrayComponents.Hide();
            labelAboveBox.Hide();
            enterButton.Hide();

            sortButton.Show();           

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < numbersArray.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbersArray[j - 1].getNumber() > numbersArray[j].getNumber())
                    {                     
                        if (numbersArray[j].isDown().Equals(false))
                        {
                            numbersArray[j].MoveDown();
                            numbersArray[j].setDownFlag(true);
                        }
                        
                        numbersArray[j - 1].MoveRight();
                        numbersArray[j].MoveLeft();
                        if (((j-2) >= 0)  && numbersArray[j - 2].getNumber() > numbersArray[j].getNumber())
                        {                           
                            TextBoxArrayComponent temp = numbersArray[j - 1];
                            numbersArray[j - 1] = numbersArray[j];
                            numbersArray[j] = temp;
                        }
                        else
                        {
                            numbersArray[j].MoveUp();
                            numbersArray[j].setDownFlag(false);
                            TextBoxArrayComponent temp = numbersArray[j - 1];
                            numbersArray[j - 1] = numbersArray[j];
                            numbersArray[j] = temp;
                        }
                    }                   
                }
            }

            this.sortedLabel.Show();
        }       
    }
}
