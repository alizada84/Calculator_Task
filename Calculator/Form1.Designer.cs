namespace Calculator
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
            panel1 = new Panel();
            textNum = new TextBox();
            btnC = new Button();
            btnEquals = new Button();
            btnNum9 = new Button();
            btnAdd = new Button();
            btnSubtr = new Button();
            btnMultip = new Button();
            btnDivis = new Button();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            button1 = new Button();
            btnNum0 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(textNum);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 181);
            panel1.TabIndex = 0;
            // 
            // textNum
            // 
            textNum.BackColor = Color.RoyalBlue;
            textNum.BorderStyle = BorderStyle.FixedSingle;
            textNum.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textNum.Location = new Point(3, 131);
            textNum.Name = "textNum";
            textNum.Size = new Size(336, 39);
            textNum.TabIndex = 0;
            // 
            // btnC
            // 
            btnC.BackColor = Color.DodgerBlue;
            btnC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.Location = new Point(3, 487);
            btnC.Name = "btnC";
            btnC.Size = new Size(117, 68);
            btnC.TabIndex = 1;
            btnC.Text = "AC";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnAC_Click;
            // 
            // btnEquals
            // 
            btnEquals.AccessibleRole = AccessibleRole.Slider;
            btnEquals.BackColor = Color.Firebrick;
            btnEquals.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(264, 487);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(151, 68);
            btnEquals.TabIndex = 2;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEqual_Click;
            // 
            // btnNum9
            // 
            btnNum9.AccessibleRole = AccessibleRole.Slider;
            btnNum9.BackColor = Color.DimGray;
            btnNum9.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum9.Location = new Point(225, 408);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(99, 78);
            btnNum9.TabIndex = 3;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(321, 179);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 79);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtr
            // 
            btnSubtr.BackColor = Color.Gold;
            btnSubtr.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtr.Location = new Point(304, 254);
            btnSubtr.Name = "btnSubtr";
            btnSubtr.Size = new Size(111, 80);
            btnSubtr.TabIndex = 5;
            btnSubtr.Text = "-";
            btnSubtr.UseVisualStyleBackColor = false;
            btnSubtr.Click += btnSubtr_Click;
            // 
            // btnMultip
            // 
            btnMultip.BackColor = Color.Gold;
            btnMultip.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultip.Location = new Point(304, 330);
            btnMultip.Name = "btnMultip";
            btnMultip.Size = new Size(111, 80);
            btnMultip.TabIndex = 6;
            btnMultip.Text = "X";
            btnMultip.UseVisualStyleBackColor = false;
            btnMultip.Click += btnMultip_Click;
            // 
            // btnDivis
            // 
            btnDivis.BackColor = Color.Gold;
            btnDivis.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivis.Location = new Point(321, 408);
            btnDivis.Name = "btnDivis";
            btnDivis.Size = new Size(94, 80);
            btnDivis.TabIndex = 7;
            btnDivis.Text = "/";
            btnDivis.UseVisualStyleBackColor = false;
            btnDivis.Click += btnDivis_Click;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = Color.DimGray;
            btnNum1.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum1.Location = new Point(3, 255);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(166, 79);
            btnNum1.TabIndex = 8;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = Color.DimGray;
            btnNum2.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum2.Location = new Point(3, 331);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(166, 79);
            btnNum2.TabIndex = 9;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = Color.DimGray;
            btnNum3.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum3.Location = new Point(3, 409);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(120, 79);
            btnNum3.TabIndex = 10;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = Color.DimGray;
            btnNum4.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum4.Location = new Point(235, 179);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(89, 79);
            btnNum4.TabIndex = 11;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = Color.DimGray;
            btnNum5.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum5.Location = new Point(117, 179);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(120, 79);
            btnNum5.TabIndex = 12;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = Color.DimGray;
            btnNum6.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum6.Location = new Point(168, 255);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(147, 79);
            btnNum6.TabIndex = 13;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = Color.DimGray;
            btnNum7.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum7.Location = new Point(168, 331);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(147, 79);
            btnNum7.TabIndex = 14;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = Color.DimGray;
            btnNum8.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum8.Location = new Point(117, 408);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(110, 79);
            btnNum8.TabIndex = 15;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum8_Click;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Slider;
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 179);
            button1.Name = "button1";
            button1.Size = new Size(120, 79);
            button1.TabIndex = 16;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnNum0_Click;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = Color.DimGray;
            btnNum0.Font = new Font("Franklin Gothic Heavy", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum0.Location = new Point(117, 485);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(147, 70);
            btnNum0.TabIndex = 17;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 553);
            Controls.Add(btnNum0);
            Controls.Add(btnC);
            Controls.Add(button1);
            Controls.Add(btnNum9);
            Controls.Add(btnNum1);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnDivis);
            Controls.Add(btnMultip);
            Controls.Add(btnSubtr);
            Controls.Add(btnAdd);
            Controls.Add(btnEquals);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnC;
        private Button btnEquals;
        private Button btnNum9;
        private Button btnAdd;
        private Button btnSubtr;
        private Button btnMultip;
        private Button btnDivis;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Label labelNew;
        private TextBox textNum;
        private Button button1;
        private Button btnNum0;
    }
}