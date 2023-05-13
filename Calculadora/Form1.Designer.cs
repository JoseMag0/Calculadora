
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_res = new System.Windows.Forms.TextBox();
            this.cmd_1 = new System.Windows.Forms.Button();
            this.cmd_2 = new System.Windows.Forms.Button();
            this.cmd_3 = new System.Windows.Forms.Button();
            this.cmd_6 = new System.Windows.Forms.Button();
            this.cmd_5 = new System.Windows.Forms.Button();
            this.cmd_4 = new System.Windows.Forms.Button();
            this.cmd_9 = new System.Windows.Forms.Button();
            this.cmd_8 = new System.Windows.Forms.Button();
            this.cmd_7 = new System.Windows.Forms.Button();
            this.cmd_ernum = new System.Windows.Forms.Button();
            this.cmd_erlast = new System.Windows.Forms.Button();
            this.cmd_erall = new System.Windows.Forms.Button();
            this.cmd_0 = new System.Windows.Forms.Button();
            this.cmd_dot = new System.Windows.Forms.Button();
            this.cmd_div = new System.Windows.Forms.Button();
            this.cmd_mult = new System.Windows.Forms.Button();
            this.cmd_res = new System.Windows.Forms.Button();
            this.cmd_suma = new System.Windows.Forms.Button();
            this.cmd_igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_res
            // 
            this.txt_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_res.Location = new System.Drawing.Point(12, 40);
            this.txt_res.MaxLength = 16;
            this.txt_res.Multiline = true;
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(405, 51);
            this.txt_res.TabIndex = 0;
            this.txt_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmd_1
            // 
            this.cmd_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_1.Location = new System.Drawing.Point(13, 384);
            this.cmd_1.Name = "cmd_1";
            this.cmd_1.Size = new System.Drawing.Size(85, 65);
            this.cmd_1.TabIndex = 1;
            this.cmd_1.Text = "1";
            this.cmd_1.UseVisualStyleBackColor = true;
            this.cmd_1.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_2
            // 
            this.cmd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_2.Location = new System.Drawing.Point(121, 384);
            this.cmd_2.Name = "cmd_2";
            this.cmd_2.Size = new System.Drawing.Size(85, 65);
            this.cmd_2.TabIndex = 2;
            this.cmd_2.Text = "2";
            this.cmd_2.UseVisualStyleBackColor = true;
            this.cmd_2.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_3
            // 
            this.cmd_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_3.Location = new System.Drawing.Point(223, 384);
            this.cmd_3.Name = "cmd_3";
            this.cmd_3.Size = new System.Drawing.Size(85, 65);
            this.cmd_3.TabIndex = 3;
            this.cmd_3.Text = "3";
            this.cmd_3.UseVisualStyleBackColor = true;
            this.cmd_3.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_6
            // 
            this.cmd_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_6.Location = new System.Drawing.Point(223, 294);
            this.cmd_6.Name = "cmd_6";
            this.cmd_6.Size = new System.Drawing.Size(85, 65);
            this.cmd_6.TabIndex = 6;
            this.cmd_6.Text = "6";
            this.cmd_6.UseVisualStyleBackColor = true;
            this.cmd_6.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_5
            // 
            this.cmd_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_5.Location = new System.Drawing.Point(124, 294);
            this.cmd_5.Name = "cmd_5";
            this.cmd_5.Size = new System.Drawing.Size(85, 65);
            this.cmd_5.TabIndex = 5;
            this.cmd_5.Text = "5";
            this.cmd_5.UseVisualStyleBackColor = true;
            this.cmd_5.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_4
            // 
            this.cmd_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_4.Location = new System.Drawing.Point(16, 294);
            this.cmd_4.Name = "cmd_4";
            this.cmd_4.Size = new System.Drawing.Size(85, 65);
            this.cmd_4.TabIndex = 4;
            this.cmd_4.Text = "4";
            this.cmd_4.UseVisualStyleBackColor = true;
            this.cmd_4.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_9
            // 
            this.cmd_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_9.Location = new System.Drawing.Point(223, 202);
            this.cmd_9.Name = "cmd_9";
            this.cmd_9.Size = new System.Drawing.Size(85, 65);
            this.cmd_9.TabIndex = 9;
            this.cmd_9.Text = "9";
            this.cmd_9.UseVisualStyleBackColor = true;
            this.cmd_9.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_8
            // 
            this.cmd_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_8.Location = new System.Drawing.Point(124, 202);
            this.cmd_8.Name = "cmd_8";
            this.cmd_8.Size = new System.Drawing.Size(85, 65);
            this.cmd_8.TabIndex = 8;
            this.cmd_8.Text = "8";
            this.cmd_8.UseVisualStyleBackColor = true;
            this.cmd_8.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_7
            // 
            this.cmd_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_7.Location = new System.Drawing.Point(16, 202);
            this.cmd_7.Name = "cmd_7";
            this.cmd_7.Size = new System.Drawing.Size(85, 65);
            this.cmd_7.TabIndex = 7;
            this.cmd_7.Text = "7";
            this.cmd_7.UseVisualStyleBackColor = true;
            this.cmd_7.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_ernum
            // 
            this.cmd_ernum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ernum.Location = new System.Drawing.Point(223, 117);
            this.cmd_ernum.Name = "cmd_ernum";
            this.cmd_ernum.Size = new System.Drawing.Size(85, 65);
            this.cmd_ernum.TabIndex = 12;
            this.cmd_ernum.Text = "<--";
            this.cmd_ernum.UseVisualStyleBackColor = true;
            this.cmd_ernum.Click += new System.EventHandler(this.cmd_ernum_Click);
            // 
            // cmd_erlast
            // 
            this.cmd_erlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_erlast.Location = new System.Drawing.Point(124, 117);
            this.cmd_erlast.Name = "cmd_erlast";
            this.cmd_erlast.Size = new System.Drawing.Size(85, 65);
            this.cmd_erlast.TabIndex = 11;
            this.cmd_erlast.Text = "C";
            this.cmd_erlast.UseVisualStyleBackColor = true;
            this.cmd_erlast.Click += new System.EventHandler(this.cmd_erlast_Click);
            // 
            // cmd_erall
            // 
            this.cmd_erall.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_erall.Location = new System.Drawing.Point(16, 117);
            this.cmd_erall.Name = "cmd_erall";
            this.cmd_erall.Size = new System.Drawing.Size(85, 65);
            this.cmd_erall.TabIndex = 10;
            this.cmd_erall.Text = "CE";
            this.cmd_erall.UseVisualStyleBackColor = true;
            this.cmd_erall.Click += new System.EventHandler(this.cmd_erall_Click);
            // 
            // cmd_0
            // 
            this.cmd_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_0.Location = new System.Drawing.Point(121, 471);
            this.cmd_0.Name = "cmd_0";
            this.cmd_0.Size = new System.Drawing.Size(85, 65);
            this.cmd_0.TabIndex = 13;
            this.cmd_0.Text = "0";
            this.cmd_0.UseVisualStyleBackColor = true;
            this.cmd_0.Click += new System.EventHandler(this.agregarnumero);
            // 
            // cmd_dot
            // 
            this.cmd_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_dot.Location = new System.Drawing.Point(13, 471);
            this.cmd_dot.Name = "cmd_dot";
            this.cmd_dot.Size = new System.Drawing.Size(85, 65);
            this.cmd_dot.TabIndex = 14;
            this.cmd_dot.Text = ".";
            this.cmd_dot.UseVisualStyleBackColor = true;
            this.cmd_dot.Click += new System.EventHandler(this.cmd_dot_Click);
            // 
            // cmd_div
            // 
            this.cmd_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_div.Location = new System.Drawing.Point(332, 117);
            this.cmd_div.Name = "cmd_div";
            this.cmd_div.Size = new System.Drawing.Size(85, 65);
            this.cmd_div.TabIndex = 18;
            this.cmd_div.Text = "/";
            this.cmd_div.UseVisualStyleBackColor = true;
            this.cmd_div.Click += new System.EventHandler(this.clickop);
            // 
            // cmd_mult
            // 
            this.cmd_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_mult.Location = new System.Drawing.Point(332, 202);
            this.cmd_mult.Name = "cmd_mult";
            this.cmd_mult.Size = new System.Drawing.Size(85, 65);
            this.cmd_mult.TabIndex = 17;
            this.cmd_mult.Text = "*";
            this.cmd_mult.UseVisualStyleBackColor = true;
            this.cmd_mult.Click += new System.EventHandler(this.clickop);
            // 
            // cmd_res
            // 
            this.cmd_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_res.Location = new System.Drawing.Point(332, 294);
            this.cmd_res.Name = "cmd_res";
            this.cmd_res.Size = new System.Drawing.Size(85, 65);
            this.cmd_res.TabIndex = 16;
            this.cmd_res.Text = "-";
            this.cmd_res.UseVisualStyleBackColor = true;
            this.cmd_res.Click += new System.EventHandler(this.clickop);
            // 
            // cmd_suma
            // 
            this.cmd_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_suma.Location = new System.Drawing.Point(332, 384);
            this.cmd_suma.Name = "cmd_suma";
            this.cmd_suma.Size = new System.Drawing.Size(85, 65);
            this.cmd_suma.TabIndex = 15;
            this.cmd_suma.Text = "+";
            this.cmd_suma.UseVisualStyleBackColor = true;
            this.cmd_suma.Click += new System.EventHandler(this.clickop);
            // 
            // cmd_igual
            // 
            this.cmd_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_igual.Location = new System.Drawing.Point(223, 471);
            this.cmd_igual.Name = "cmd_igual";
            this.cmd_igual.Size = new System.Drawing.Size(194, 65);
            this.cmd_igual.TabIndex = 19;
            this.cmd_igual.Text = "=";
            this.cmd_igual.UseVisualStyleBackColor = true;
            this.cmd_igual.Click += new System.EventHandler(this.cmd_igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 558);
            this.Controls.Add(this.cmd_igual);
            this.Controls.Add(this.cmd_div);
            this.Controls.Add(this.cmd_mult);
            this.Controls.Add(this.cmd_res);
            this.Controls.Add(this.cmd_suma);
            this.Controls.Add(this.cmd_dot);
            this.Controls.Add(this.cmd_0);
            this.Controls.Add(this.cmd_ernum);
            this.Controls.Add(this.cmd_erlast);
            this.Controls.Add(this.cmd_erall);
            this.Controls.Add(this.cmd_9);
            this.Controls.Add(this.cmd_8);
            this.Controls.Add(this.cmd_7);
            this.Controls.Add(this.cmd_6);
            this.Controls.Add(this.cmd_5);
            this.Controls.Add(this.cmd_4);
            this.Controls.Add(this.cmd_3);
            this.Controls.Add(this.cmd_2);
            this.Controls.Add(this.cmd_1);
            this.Controls.Add(this.txt_res);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button cmd_1;
        private System.Windows.Forms.Button cmd_2;
        private System.Windows.Forms.Button cmd_3;
        private System.Windows.Forms.Button cmd_6;
        private System.Windows.Forms.Button cmd_5;
        private System.Windows.Forms.Button cmd_4;
        private System.Windows.Forms.Button cmd_9;
        private System.Windows.Forms.Button cmd_8;
        private System.Windows.Forms.Button cmd_7;
        private System.Windows.Forms.Button cmd_ernum;
        private System.Windows.Forms.Button cmd_erlast;
        private System.Windows.Forms.Button cmd_erall;
        private System.Windows.Forms.Button cmd_0;
        private System.Windows.Forms.Button cmd_dot;
        private System.Windows.Forms.Button cmd_div;
        private System.Windows.Forms.Button cmd_mult;
        private System.Windows.Forms.Button cmd_res;
        private System.Windows.Forms.Button cmd_suma;
        private System.Windows.Forms.Button cmd_igual;
    }
}

