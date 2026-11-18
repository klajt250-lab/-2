namespace paint
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
            pictureBox1 = new PictureBox();
            Save = new Button();
            Clear = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button11 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            trackBar1 = new TrackBar();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(958, 561);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Save
            // 
            Save.Location = new Point(15, 485);
            Save.Name = "Save";
            Save.Size = new Size(161, 29);
            Save.TabIndex = 1;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button1_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(15, 520);
            Clear.Name = "Clear";
            Clear.Size = new Size(161, 29);
            Clear.TabIndex = 2;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 94);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(39, 3);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(75, 3);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(111, 3);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(147, 3);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(3, 39);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button1_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.Cyan;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(39, 39);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button1_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.Blue;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(111, 39);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button1_Click_1;
            // 
            // button9
            // 
            button9.BackColor = Color.Fuchsia;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(75, 39);
            button9.Name = "button9";
            button9.Size = new Size(30, 30);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button1_Click_1;
            // 
            // button11
            // 
            button11.Location = new Point(147, 39);
            button11.Name = "button11";
            button11.Size = new Size(30, 30);
            button11.TabIndex = 10;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBar1);
            panel1.Location = new Point(1, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 68);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Enabled = false;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(0, 45);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 1;
            label1.Text = "Выбор толщины";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Top;
            trackBar1.Location = new Point(0, 0);
            trackBar1.Maximum = 20;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(200, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            trackBar1.Validated += trackBar1_Validated;
            // 
            // panel2
            // 
            panel2.Controls.Add(Clear);
            panel2.Controls.Add(Save);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(757, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 561);
            panel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 561);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Save;
        private Button Clear;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button11;
        private Panel panel1;
        private Label label1;
        private TrackBar trackBar1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2;
    }
}
