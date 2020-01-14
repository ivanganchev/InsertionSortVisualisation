namespace InsertionSortAnimation
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartButton.BackgroundImage = global::InsertionSortAnimation.Properties.Resources._1;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(258, 151);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(265, 66);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sortButton.BackgroundImage = global::InsertionSortAnimation.Properties.Resources._1;
            this.sortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortButton.FlatAppearance.BorderSize = 0;
            this.sortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortButton.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(598, 395);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(174, 52);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Visible = false;
            this.sortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindowForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button sortButton;
    }
}

