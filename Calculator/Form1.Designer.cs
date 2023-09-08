namespace Calculator
{
    partial class Form1
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
            this.Factor1TextBox = new System.Windows.Forms.TextBox();
            this.Factor2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumpadMinus = new System.Windows.Forms.Button();
            this.textResultBox = new System.Windows.Forms.TextBox();
            this.Numpad4 = new System.Windows.Forms.Button();
            this.Numpad5 = new System.Windows.Forms.Button();
            this.Numpad6 = new System.Windows.Forms.Button();
            this.Numpad1 = new System.Windows.Forms.Button();
            this.Numpad2 = new System.Windows.Forms.Button();
            this.Numpad3 = new System.Windows.Forms.Button();
            this.Numpad7 = new System.Windows.Forms.Button();
            this.Numpad8 = new System.Windows.Forms.Button();
            this.Numpad9 = new System.Windows.Forms.Button();
            this.NumpadMultiply = new System.Windows.Forms.Button();
            this.NumpadPlus = new System.Windows.Forms.Button();
            this.NumpadDivide = new System.Windows.Forms.Button();
            this.NumpadRemainder = new System.Windows.Forms.Button();
            this.NumpadExponent = new System.Windows.Forms.Button();
            this.NumpadEquals = new System.Windows.Forms.Button();
            this.Numpad0 = new System.Windows.Forms.Button();
            this.numpadDot = new System.Windows.Forms.Button();
            this.OperatorTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.trollBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Factor1TextBox
            // 
            this.Factor1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factor1TextBox.Location = new System.Drawing.Point(73, 89);
            this.Factor1TextBox.Name = "Factor1TextBox";
            this.Factor1TextBox.Size = new System.Drawing.Size(140, 49);
            this.Factor1TextBox.TabIndex = 0;
            // 
            // Factor2TextBox
            // 
            this.Factor2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factor2TextBox.Location = new System.Drawing.Point(365, 89);
            this.Factor2TextBox.Name = "Factor2TextBox";
            this.Factor2TextBox.Size = new System.Drawing.Size(140, 49);
            this.Factor2TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculator";
            // 
            // NumpadMinus
            // 
            this.NumpadMinus.FlatAppearance.BorderSize = 0;
            this.NumpadMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumpadMinus.Location = new System.Drawing.Point(430, 233);
            this.NumpadMinus.Name = "NumpadMinus";
            this.NumpadMinus.Size = new System.Drawing.Size(75, 63);
            this.NumpadMinus.TabIndex = 5;
            this.NumpadMinus.Text = "-";
            this.NumpadMinus.UseVisualStyleBackColor = true;
            this.NumpadMinus.Click += new System.EventHandler(this.operatorClicked);
            this.NumpadMinus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // textResultBox
            // 
            this.textResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultBox.Location = new System.Drawing.Point(554, 89);
            this.textResultBox.Name = "textResultBox";
            this.textResultBox.Size = new System.Drawing.Size(140, 49);
            this.textResultBox.TabIndex = 6;
            // 
            // Numpad4
            // 
            this.Numpad4.FlatAppearance.BorderSize = 0;
            this.Numpad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad4.Location = new System.Drawing.Point(73, 233);
            this.Numpad4.Name = "Numpad4";
            this.Numpad4.Size = new System.Drawing.Size(75, 63);
            this.Numpad4.TabIndex = 5;
            this.Numpad4.Text = "4";
            this.Numpad4.UseVisualStyleBackColor = true;
            this.Numpad4.Click += new System.EventHandler(this.numpadClick);
            this.Numpad4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad5
            // 
            this.Numpad5.FlatAppearance.BorderSize = 0;
            this.Numpad5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad5.Location = new System.Drawing.Point(166, 233);
            this.Numpad5.Name = "Numpad5";
            this.Numpad5.Size = new System.Drawing.Size(75, 63);
            this.Numpad5.TabIndex = 5;
            this.Numpad5.Text = "5";
            this.Numpad5.UseVisualStyleBackColor = true;
            this.Numpad5.Click += new System.EventHandler(this.numpadClick);
            this.Numpad5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad6
            // 
            this.Numpad6.FlatAppearance.BorderSize = 0;
            this.Numpad6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad6.Location = new System.Drawing.Point(263, 233);
            this.Numpad6.Name = "Numpad6";
            this.Numpad6.Size = new System.Drawing.Size(75, 63);
            this.Numpad6.TabIndex = 5;
            this.Numpad6.Text = "6";
            this.Numpad6.UseVisualStyleBackColor = true;
            this.Numpad6.Click += new System.EventHandler(this.numpadClick);
            this.Numpad6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad1
            // 
            this.Numpad1.FlatAppearance.BorderSize = 0;
            this.Numpad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad1.Location = new System.Drawing.Point(73, 308);
            this.Numpad1.Name = "Numpad1";
            this.Numpad1.Size = new System.Drawing.Size(75, 63);
            this.Numpad1.TabIndex = 5;
            this.Numpad1.Text = "1";
            this.Numpad1.UseVisualStyleBackColor = true;
            this.Numpad1.Click += new System.EventHandler(this.numpadClick);
            this.Numpad1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad2
            // 
            this.Numpad2.FlatAppearance.BorderSize = 0;
            this.Numpad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad2.Location = new System.Drawing.Point(166, 308);
            this.Numpad2.Name = "Numpad2";
            this.Numpad2.Size = new System.Drawing.Size(75, 63);
            this.Numpad2.TabIndex = 5;
            this.Numpad2.Text = "2";
            this.Numpad2.UseVisualStyleBackColor = true;
            this.Numpad2.Click += new System.EventHandler(this.numpadClick);
            this.Numpad2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad3
            // 
            this.Numpad3.FlatAppearance.BorderSize = 0;
            this.Numpad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad3.Location = new System.Drawing.Point(263, 308);
            this.Numpad3.Name = "Numpad3";
            this.Numpad3.Size = new System.Drawing.Size(75, 63);
            this.Numpad3.TabIndex = 5;
            this.Numpad3.Text = "3";
            this.Numpad3.UseVisualStyleBackColor = true;
            this.Numpad3.Click += new System.EventHandler(this.numpadClick);
            this.Numpad3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad7
            // 
            this.Numpad7.FlatAppearance.BorderSize = 0;
            this.Numpad7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad7.Location = new System.Drawing.Point(73, 164);
            this.Numpad7.Name = "Numpad7";
            this.Numpad7.Size = new System.Drawing.Size(75, 63);
            this.Numpad7.TabIndex = 5;
            this.Numpad7.Text = "7";
            this.Numpad7.UseVisualStyleBackColor = true;
            this.Numpad7.Click += new System.EventHandler(this.numpadClick);
            this.Numpad7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad8
            // 
            this.Numpad8.FlatAppearance.BorderSize = 0;
            this.Numpad8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad8.Location = new System.Drawing.Point(166, 164);
            this.Numpad8.Name = "Numpad8";
            this.Numpad8.Size = new System.Drawing.Size(75, 63);
            this.Numpad8.TabIndex = 5;
            this.Numpad8.Text = "8";
            this.Numpad8.UseVisualStyleBackColor = true;
            this.Numpad8.Click += new System.EventHandler(this.numpadClick);
            this.Numpad8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad9
            // 
            this.Numpad9.FlatAppearance.BorderSize = 0;
            this.Numpad9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad9.Location = new System.Drawing.Point(263, 164);
            this.Numpad9.Name = "Numpad9";
            this.Numpad9.Size = new System.Drawing.Size(75, 63);
            this.Numpad9.TabIndex = 5;
            this.Numpad9.Text = "9";
            this.Numpad9.UseVisualStyleBackColor = true;
            this.Numpad9.Click += new System.EventHandler(this.numpadClick);
            this.Numpad9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // NumpadMultiply
            // 
            this.NumpadMultiply.FlatAppearance.BorderSize = 0;
            this.NumpadMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumpadMultiply.Location = new System.Drawing.Point(430, 308);
            this.NumpadMultiply.Name = "NumpadMultiply";
            this.NumpadMultiply.Size = new System.Drawing.Size(75, 63);
            this.NumpadMultiply.TabIndex = 5;
            this.NumpadMultiply.Text = "*";
            this.NumpadMultiply.UseVisualStyleBackColor = true;
            this.NumpadMultiply.Click += new System.EventHandler(this.operatorClicked);
            this.NumpadMultiply.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // NumpadPlus
            // 
            this.NumpadPlus.FlatAppearance.BorderSize = 0;
            this.NumpadPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumpadPlus.Location = new System.Drawing.Point(430, 164);
            this.NumpadPlus.Name = "NumpadPlus";
            this.NumpadPlus.Size = new System.Drawing.Size(75, 63);
            this.NumpadPlus.TabIndex = 5;
            this.NumpadPlus.Text = "+";
            this.NumpadPlus.UseVisualStyleBackColor = true;
            this.NumpadPlus.Click += new System.EventHandler(this.operatorClicked);
            this.NumpadPlus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // NumpadDivide
            // 
            this.NumpadDivide.FlatAppearance.BorderSize = 0;
            this.NumpadDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumpadDivide.Location = new System.Drawing.Point(520, 164);
            this.NumpadDivide.Name = "NumpadDivide";
            this.NumpadDivide.Size = new System.Drawing.Size(75, 63);
            this.NumpadDivide.TabIndex = 5;
            this.NumpadDivide.Text = "/";
            this.NumpadDivide.UseVisualStyleBackColor = true;
            this.NumpadDivide.Click += new System.EventHandler(this.operatorClicked);
            this.NumpadDivide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // NumpadRemainder
            // 
            this.NumpadRemainder.FlatAppearance.BorderSize = 0;
            this.NumpadRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumpadRemainder.Location = new System.Drawing.Point(520, 233);
            this.NumpadRemainder.Name = "NumpadRemainder";
            this.NumpadRemainder.Size = new System.Drawing.Size(75, 63);
            this.NumpadRemainder.TabIndex = 5;
            this.NumpadRemainder.Text = "%";
            this.NumpadRemainder.UseVisualStyleBackColor = true;
            this.NumpadRemainder.Click += new System.EventHandler(this.operatorClicked);
            this.NumpadRemainder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // NumpadExponent
            // 
            this.NumpadExponent.FlatAppearance.BorderSize = 0;
            this.NumpadExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumpadExponent.Location = new System.Drawing.Point(520, 308);
            this.NumpadExponent.Name = "NumpadExponent";
            this.NumpadExponent.Size = new System.Drawing.Size(75, 63);
            this.NumpadExponent.TabIndex = 5;
            this.NumpadExponent.Text = "^";
            this.NumpadExponent.UseVisualStyleBackColor = true;
            this.NumpadExponent.Click += new System.EventHandler(this.operatorClicked);
            this.NumpadExponent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // NumpadEquals
            // 
            this.NumpadEquals.FlatAppearance.BorderSize = 0;
            this.NumpadEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumpadEquals.Location = new System.Drawing.Point(610, 233);
            this.NumpadEquals.Name = "NumpadEquals";
            this.NumpadEquals.Size = new System.Drawing.Size(75, 63);
            this.NumpadEquals.TabIndex = 5;
            this.NumpadEquals.Text = "=";
            this.NumpadEquals.UseVisualStyleBackColor = true;
            this.NumpadEquals.Click += new System.EventHandler(this.getResult);
            this.NumpadEquals.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // Numpad0
            // 
            this.Numpad0.FlatAppearance.BorderSize = 0;
            this.Numpad0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numpad0.Location = new System.Drawing.Point(73, 377);
            this.Numpad0.Name = "Numpad0";
            this.Numpad0.Size = new System.Drawing.Size(168, 61);
            this.Numpad0.TabIndex = 7;
            this.Numpad0.Text = "0";
            this.Numpad0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Numpad0.UseVisualStyleBackColor = true;
            this.Numpad0.Click += new System.EventHandler(this.numpadClick);
            this.Numpad0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // numpadDot
            // 
            this.numpadDot.FlatAppearance.BorderSize = 0;
            this.numpadDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpadDot.Location = new System.Drawing.Point(263, 377);
            this.numpadDot.Name = "numpadDot";
            this.numpadDot.Size = new System.Drawing.Size(75, 61);
            this.numpadDot.TabIndex = 7;
            this.numpadDot.Text = ".";
            this.numpadDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.numpadDot.UseVisualStyleBackColor = true;
            this.numpadDot.Click += new System.EventHandler(this.numpadClick);
            this.numpadDot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // OperatorTextBox
            // 
            this.OperatorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorTextBox.Location = new System.Drawing.Point(251, 89);
            this.OperatorTextBox.Name = "OperatorTextBox";
            this.OperatorTextBox.Size = new System.Drawing.Size(75, 49);
            this.OperatorTextBox.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(610, 164);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 63);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearClicked);
            this.clearButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.numpad_MouseMove);
            // 
            // trollBox
            // 
            this.trollBox.AutoSize = true;
            this.trollBox.Location = new System.Drawing.Point(610, 333);
            this.trollBox.Name = "trollBox";
            this.trollBox.Size = new System.Drawing.Size(113, 29);
            this.trollBox.TabIndex = 8;
            this.trollBox.Text = "Trolling?";
            this.trollBox.UseVisualStyleBackColor = true;
            this.trollBox.CheckedChanged += new System.EventHandler(this.changeTrollMode);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trollBox);
            this.Controls.Add(this.numpadDot);
            this.Controls.Add(this.Numpad0);
            this.Controls.Add(this.textResultBox);
            this.Controls.Add(this.Numpad9);
            this.Controls.Add(this.Numpad8);
            this.Controls.Add(this.Numpad3);
            this.Controls.Add(this.Numpad2);
            this.Controls.Add(this.Numpad7);
            this.Controls.Add(this.Numpad6);
            this.Controls.Add(this.Numpad1);
            this.Controls.Add(this.Numpad5);
            this.Controls.Add(this.Numpad4);
            this.Controls.Add(this.NumpadMultiply);
            this.Controls.Add(this.NumpadExponent);
            this.Controls.Add(this.NumpadRemainder);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.NumpadDivide);
            this.Controls.Add(this.NumpadEquals);
            this.Controls.Add(this.NumpadPlus);
            this.Controls.Add(this.NumpadMinus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorTextBox);
            this.Controls.Add(this.Factor2TextBox);
            this.Controls.Add(this.Factor1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Factor1TextBox;
        private System.Windows.Forms.TextBox Factor2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NumpadMinus;
        private System.Windows.Forms.TextBox textResultBox;
        private System.Windows.Forms.Button Numpad4;
        private System.Windows.Forms.Button Numpad5;
        private System.Windows.Forms.Button Numpad6;
        private System.Windows.Forms.Button Numpad1;
        private System.Windows.Forms.Button Numpad2;
        private System.Windows.Forms.Button Numpad3;
        private System.Windows.Forms.Button Numpad7;
        private System.Windows.Forms.Button Numpad8;
        private System.Windows.Forms.Button Numpad9;
        private System.Windows.Forms.Button NumpadMultiply;
        private System.Windows.Forms.Button NumpadPlus;
        private System.Windows.Forms.Button NumpadDivide;
        private System.Windows.Forms.Button NumpadRemainder;
        private System.Windows.Forms.Button NumpadExponent;
        private System.Windows.Forms.Button NumpadEquals;
        private System.Windows.Forms.Button Numpad0;
        private System.Windows.Forms.Button numpadDot;
        private System.Windows.Forms.TextBox OperatorTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox trollBox;
    }
}

