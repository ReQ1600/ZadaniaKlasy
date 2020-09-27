namespace zad8
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
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbIte = new System.Windows.Forms.RadioButton();
            this.rbReku = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num.Location = new System.Drawing.Point(313, 19);
            this.num.Maximum = new decimal(new int[] {
            166,
            0,
            0,
            0});
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(122, 22);
            this.num.TabIndex = 0;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "numer wyrazu, który ma zostać obliczony";
            // 
            // btnCount
            // 
            this.btnCount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCount.Location = new System.Drawing.Point(173, 126);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(103, 46);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Oblicz";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // tb
            // 
            this.tb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb.Location = new System.Drawing.Point(16, 98);
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(419, 13);
            this.tb.TabIndex = 3;
            this.tb.Text = "[  ]";
            this.tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(199, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wynik:";
            // 
            // rbIte
            // 
            this.rbIte.AutoSize = true;
            this.rbIte.Checked = true;
            this.rbIte.Location = new System.Drawing.Point(17, 26);
            this.rbIte.Name = "rbIte";
            this.rbIte.Size = new System.Drawing.Size(60, 17);
            this.rbIte.TabIndex = 5;
            this.rbIte.TabStop = true;
            this.rbIte.Text = "Iteracja";
            this.rbIte.UseVisualStyleBackColor = true;
            // 
            // rbReku
            // 
            this.rbReku.AutoSize = true;
            this.rbReku.Location = new System.Drawing.Point(17, 59);
            this.rbReku.Name = "rbReku";
            this.rbReku.Size = new System.Drawing.Size(80, 17);
            this.rbReku.TabIndex = 6;
            this.rbReku.Text = "Rekurencja";
            this.rbReku.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIte);
            this.groupBox1.Controls.Add(this.rbReku);
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sposób obliczenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ciąg Fibonacciego";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbIte;
        private System.Windows.Forms.RadioButton rbReku;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

