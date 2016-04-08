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
            this.firstArg = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.secondArg = new System.Windows.Forms.TextBox();
            this.outArg = new System.Windows.Forms.Label();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstArg
            // 
            this.firstArg.Location = new System.Drawing.Point(35, 37);
            this.firstArg.Name = "firstArg";
            this.firstArg.Size = new System.Drawing.Size(146, 20);
            this.firstArg.TabIndex = 0;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(35, 89);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(89, 101);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Calculate);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(143, 89);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(97, 101);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Calculate);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(260, 89);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(97, 101);
            this.multiply.TabIndex = 3;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Calculate);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(377, 89);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(97, 101);
            this.divide.TabIndex = 4;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Calculate);
            // 
            // secondArg
            // 
            this.secondArg.Location = new System.Drawing.Point(196, 37);
            this.secondArg.Name = "secondArg";
            this.secondArg.Size = new System.Drawing.Size(146, 20);
            this.secondArg.TabIndex = 5;
            // 
            // outArg
            // 
            this.outArg.AutoSize = true;
            this.outArg.Location = new System.Drawing.Point(398, 40);
            this.outArg.Name = "outArg";
            this.outArg.Size = new System.Drawing.Size(0, 13);
            this.outArg.TabIndex = 6;
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(35, 209);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(89, 101);
            this.sin.TabIndex = 7;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(143, 209);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(97, 101);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 412);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.outArg);
            this.Controls.Add(this.secondArg);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.firstArg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstArg;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox secondArg;
        private System.Windows.Forms.Label outArg;
        protected System.Windows.Forms.Button plus;
        protected System.Windows.Forms.Button sin;
        protected System.Windows.Forms.Button cos;
    }
}

