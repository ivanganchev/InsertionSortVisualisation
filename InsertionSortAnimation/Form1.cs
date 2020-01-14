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
        public MainWindowForm()
        {
            InitializeComponent();

        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            numbersArray = new List<TextBoxArrayComponent>();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();

            arrayComponents = new TextBox();
            arrayComponents.Location = new Point((this.Size.Width / 2) - (arrayComponents.Size.Width / 2), 40);
            labelAboveBox = new Label();
            labelAboveBox.Location = new Point((this.Size.Width / 2) - (arrayComponents.Size.Width / 2), arrayComponents.Location.Y - arrayComponents.Size.Height);
            labelAboveBox.AutoSize = true;
            labelAboveBox.MaximumSize = new System.Drawing.Size(this.Size.Width, labelAboveBox.Size.Height);
            labelAboveBox.Text = "Enter array components.";
            enterButton = new Button();
            enterButton.Size = new Size(arrayComponents.Size.Width, arrayComponents.Size.Height);
            enterButton.Text = "Enter";
            enterButton.Location = new Point(arrayComponents.Location.X + arrayComponents.Size.Width, arrayComponents.Location.Y);
            enterButton.Click += new EventHandler(this.enterButton_Click);

            this.Controls.Add(arrayComponents);
            this.Controls.Add(labelAboveBox);
            this.Controls.Add(enterButton);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            string[] numbers = arrayComponents.Text.Split(',').ToArray();
            int currentX = 0;
            //int spaceBetweenBoxes = 30;

            for(int i = 0; i < numbers.Length; i++)
            {
                TextBoxArrayComponent tbx = new TextBoxArrayComponent();
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
            sortButton.Click += new EventHandler(this.SortButton_Click);

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            insertSortAnimated(numbersArray);
            while (true) {
                //Thread.Sleep(500);
                numbersArray[1].MoveDown(numbersArray[1].Location.X, numbersArray[1].Location.X);
            }
        }


        private void insertSortAnimated(List<TextBoxArrayComponent> array)
        {

        }
    }
}
