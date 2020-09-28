namespace zad9
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
            this.lbChoice = new System.Windows.Forms.ListBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.tbIn = new System.Windows.Forms.TextBox();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbChoice
            // 
            this.lbChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbChoice.FormattingEnabled = true;
            this.lbChoice.ItemHeight = 16;
            this.lbChoice.Items.AddRange(new object[] {
            "kg -> funty",
            "funty -> kg",
            "C -> F",
            "F -> C",
            "km/h - kts",
            "kts -> km/h"});
            this.lbChoice.Location = new System.Drawing.Point(31, 12);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(202, 100);
            this.lbChoice.TabIndex = 0;
            this.lbChoice.SelectedIndexChanged += new System.EventHandler(this.LbChoice_SelectedIndexChanged);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZero.Location = new System.Drawing.Point(58, 189);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(145, 38);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "Wyzeruj wybór z listy";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // lblIn
            // 
            this.lblIn.Location = new System.Drawing.Point(28, 126);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(45, 23);
            this.lblIn.TabIndex = 2;
            this.lblIn.Text = "[plchldr]";
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(188, 126);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(45, 23);
            this.lblOut.TabIndex = 3;
            this.lblOut.Text = "[plchldr]";
            // 
            // tbIn
            // 
            this.tbIn.Enabled = false;
            this.tbIn.Location = new System.Drawing.Point(31, 152);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(70, 20);
            this.tbIn.TabIndex = 4;
            this.tbIn.Text = "[  ]";
            this.tbIn.TextChanged += new System.EventHandler(this.TbIn_TextChanged);
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(163, 152);
            this.tbOut.Name = "tbOut";
            this.tbOut.ReadOnly = true;
            this.tbOut.Size = new System.Drawing.Size(70, 20);
            this.tbOut.TabIndex = 5;
            this.tbOut.Text = "[  ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(121, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.tbIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.lbChoice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 280);
            this.MinimumSize = new System.Drawing.Size(280, 280);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator wartości";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbChoice;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Label label3;
    }
}

