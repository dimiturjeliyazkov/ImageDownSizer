namespace ImageDownSizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChooseImage = new Button();
            pictureBox = new PictureBox();
            procenti = new TextBox();
            Priloji = new Button();
            PictureTLP = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            PictureTLP.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // ChooseImage
            // 
            ChooseImage.Dock = DockStyle.Fill;
            ChooseImage.Location = new Point(3, 3);
            ChooseImage.Name = "ChooseImage";
            ChooseImage.Size = new Size(229, 216);
            ChooseImage.TabIndex = 0;
            ChooseImage.Text = "Избери снимка";
            ChooseImage.UseVisualStyleBackColor = true;
            ChooseImage.Click += ChooseImage_Click;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(244, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(553, 444);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // procenti
            // 
            procenti.Dock = DockStyle.Fill;
            procenti.Location = new Point(3, 108);
            procenti.Name = "procenti";
            procenti.Size = new Size(102, 27);
            procenti.TabIndex = 4;
            // 
            // Priloji
            // 
            Priloji.Dock = DockStyle.Fill;
            Priloji.Location = new Point(117, 3);
            Priloji.Name = "Priloji";
            Priloji.Size = new Size(109, 210);
            Priloji.TabIndex = 5;
            Priloji.Text = "приложи";
            Priloji.UseVisualStyleBackColor = true;
            Priloji.Click += DownsizeImage_Click;
            // 
            // PictureTLP
            // 
            PictureTLP.ColumnCount = 2;
            PictureTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.125F));
            PictureTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.875F));
            PictureTLP.Controls.Add(pictureBox, 1, 0);
            PictureTLP.Controls.Add(tableLayoutPanel2, 0, 0);
            PictureTLP.Dock = DockStyle.Fill;
            PictureTLP.Location = new Point(0, 0);
            PictureTLP.Name = "PictureTLP";
            PictureTLP.RowCount = 1;
            PictureTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PictureTLP.Size = new Size(800, 450);
            PictureTLP.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ChooseImage, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(235, 444);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(Priloji, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 225);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(229, 216);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(procenti, 0, 1);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(108, 210);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 105);
            label1.TabIndex = 5;
            label1.Text = "Избери нов мащаб";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PictureTLP);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            PictureTLP.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ChooseImage;
        private TextBox selectedImagePathTextBox;
        private PictureBox pictureBox;
        private TextBox Height;
        private TextBox procenti;
        private Button Priloji;
        private TableLayoutPanel PictureTLP;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
    }
}
