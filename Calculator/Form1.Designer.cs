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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAdd = new Button();
            buttonDev = new Button();
            buttonSub = new Button();
            buttonClr = new Button();
            buttonMult = new Button();
            buttonEquals = new Button();
            textBoxProb = new TextBox();
            label1 = new Label();
            textBoxSol = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1, 123);
            button1.Name = "button1";
            button1.Size = new Size(94, 81);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(101, 123);
            button2.Name = "button2";
            button2.Size = new Size(94, 81);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(201, 123);
            button3.Name = "button3";
            button3.Size = new Size(94, 81);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1, 210);
            button4.Name = "button4";
            button4.Size = new Size(94, 81);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(101, 210);
            button5.Name = "button5";
            button5.Size = new Size(94, 81);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(201, 210);
            button6.Name = "button6";
            button6.Size = new Size(94, 81);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(1, 297);
            button7.Name = "button7";
            button7.Size = new Size(94, 81);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(101, 297);
            button8.Name = "button8";
            button8.Size = new Size(94, 81);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(201, 297);
            button9.Name = "button9";
            button9.Size = new Size(94, 81);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(301, 126);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(62, 81);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDev
            // 
            buttonDev.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDev.Location = new Point(301, 297);
            buttonDev.Name = "buttonDev";
            buttonDev.Size = new Size(62, 81);
            buttonDev.TabIndex = 11;
            buttonDev.Text = "/";
            buttonDev.UseVisualStyleBackColor = true;
            // 
            // buttonSub
            // 
            buttonSub.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSub.Location = new Point(301, 210);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(62, 81);
            buttonSub.TabIndex = 12;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            // 
            // buttonClr
            // 
            buttonClr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClr.Location = new Point(374, 126);
            buttonClr.Name = "buttonClr";
            buttonClr.Size = new Size(62, 81);
            buttonClr.TabIndex = 13;
            buttonClr.Text = "CLR";
            buttonClr.UseVisualStyleBackColor = true;
            // 
            // buttonMult
            // 
            buttonMult.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMult.Location = new Point(374, 213);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(62, 81);
            buttonMult.TabIndex = 14;
            buttonMult.Text = "X";
            buttonMult.UseVisualStyleBackColor = true;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEquals.Location = new Point(369, 297);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(67, 81);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += button15_Click;
            // 
            // textBoxProb
            // 
            textBoxProb.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProb.Location = new Point(12, 33);
            textBoxProb.Multiline = true;
            textBoxProb.Name = "textBoxProb";
            textBoxProb.Size = new Size(237, 59);
            textBoxProb.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(263, 52);
            label1.Name = "label1";
            label1.Size = new Size(32, 35);
            label1.TabIndex = 17;
            label1.Text = "=";
            // 
            // textBoxSol
            // 
            textBoxSol.Location = new Point(332, 33);
            textBoxSol.Multiline = true;
            textBoxSol.Name = "textBoxSol";
            textBoxSol.Size = new Size(104, 59);
            textBoxSol.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 380);
            Controls.Add(textBoxSol);
            Controls.Add(label1);
            Controls.Add(textBoxProb);
            Controls.Add(buttonEquals);
            Controls.Add(buttonMult);
            Controls.Add(buttonClr);
            Controls.Add(buttonSub);
            Controls.Add(buttonDev);
            Controls.Add(buttonAdd);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonAdd;
        private Button buttonDev;
        private Button buttonSub;
        private Button buttonClr;
        private Button buttonMult;
        private Button buttonEquals;
        private TextBox textBoxProb;
        private Label label1;
        private TextBox textBoxSol;
    }
}