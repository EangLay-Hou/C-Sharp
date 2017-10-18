namespace XOGame
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
            this.A00 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(202, 51);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(87, 68);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(202, 301);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(87, 23);
            this.NGButton.TabIndex = 1;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click_1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(295, 301);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(87, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "Reset";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // EButton
            // 
            this.EButton.Location = new System.Drawing.Point(530, 301);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(63, 23);
            this.EButton.TabIndex = 1;
            this.EButton.Text = "Exit";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // XWin
            // 
            this.XWin.AutoSize = true;
            this.XWin.Location = new System.Drawing.Point(558, 51);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(26, 13);
            this.XWin.TabIndex = 2;
            this.XWin.Text = "X: 0";
            // 
            // OWin
            // 
            this.OWin.AutoSize = true;
            this.OWin.Location = new System.Drawing.Point(558, 125);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(27, 13);
            this.OWin.TabIndex = 3;
            this.OWin.Text = "O: 0";
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(558, 199);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(49, 13);
            this.Draws.TabIndex = 4;
            this.Draws.Text = "Draws: 0";
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(202, 125);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(87, 68);
            this.A10.TabIndex = 5;
            this.A10.UseVisualStyleBackColor = true;
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(202, 199);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(87, 68);
            this.A20.TabIndex = 6;
            this.A20.UseVisualStyleBackColor = true;
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(295, 199);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(87, 68);
            this.A21.TabIndex = 9;
            this.A21.UseVisualStyleBackColor = true;
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(295, 125);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(87, 68);
            this.A11.TabIndex = 8;
            this.A11.UseVisualStyleBackColor = true;
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(295, 51);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(87, 68);
            this.A01.TabIndex = 7;
            this.A01.UseVisualStyleBackColor = true;
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(388, 199);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(87, 68);
            this.A22.TabIndex = 12;
            this.A22.UseVisualStyleBackColor = true;
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(388, 125);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(87, 68);
            this.A12.TabIndex = 11;
            this.A12.UseVisualStyleBackColor = true;
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(388, 51);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(87, 68);
            this.A02.TabIndex = 10;
            this.A02.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 430);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
    }
}

