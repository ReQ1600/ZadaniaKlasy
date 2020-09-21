namespace zad6
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
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Szary",
            "Biały"});
            this.cb1.Location = new System.Drawing.Point(12, 25);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 1;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.Cb1_SelectedIndexChanged);
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCount.Location = new System.Drawing.Point(12, 212);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(121, 34);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "Przelicz";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl.BackColor = System.Drawing.SystemColors.Control;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl.Location = new System.Drawing.Point(137, 186);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(590, 32);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "[  ]";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Szary",
            "Biały"});
            this.cb2.Location = new System.Drawing.Point(12, 75);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(121, 21);
            this.cb2.TabIndex = 10;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.Cb2_SelectedIndexChanged);
            // 
            // cb3
            // 
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Złoty",
            "Srebrny"});
            this.cb3.Location = new System.Drawing.Point(12, 125);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(121, 21);
            this.cb3.TabIndex = 11;
            this.cb3.SelectedIndexChanged += new System.EventHandler(this.Cb3_SelectedIndexChanged);
            // 
            // cb4
            // 
            this.cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb4.FormattingEnabled = true;
            this.cb4.Items.AddRange(new object[] {
            "Brązowy",
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Szary",
            "Złoty",
            "Srebrny"});
            this.cb4.Location = new System.Drawing.Point(12, 175);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(121, 21);
            this.cb4.TabIndex = 12;
            this.cb4.SelectedIndexChanged += new System.EventHandler(this.Cb4_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pierwszy pasek";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Drugi pasek";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mnożnik";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tolerancja";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.BackColor = System.Drawing.SystemColors.Desktop;
            this.pb.BackgroundImage = global::zad6.Properties.Resources.rezystor1;
            this.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb.Location = new System.Drawing.Point(158, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(586, 148);
            this.pb.TabIndex = 7;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.Pb_Click);
            this.pb.MouseLeave += new System.EventHandler(this.Pb_MouseLeave);
            this.pb.MouseHover += new System.EventHandler(this.Pb_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(289, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 114);
            this.panel1.TabIndex = 17;
            this.panel1.MouseLeave += new System.EventHandler(this.Pb_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.Pb_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(360, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 88);
            this.panel2.TabIndex = 18;
            this.panel2.MouseLeave += new System.EventHandler(this.Pb_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.Pb_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(431, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 88);
            this.panel3.TabIndex = 19;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            this.panel3.MouseLeave += new System.EventHandler(this.Pb_MouseLeave);
            this.panel3.MouseHover += new System.EventHandler(this.Pb_MouseHover);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(519, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 88);
            this.panel4.TabIndex = 20;
            this.panel4.MouseLeave += new System.EventHandler(this.Pb_MouseLeave);
            this.panel4.MouseHover += new System.EventHandler(this.Pb_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 266);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 308);
            this.MinimumSize = new System.Drawing.Size(816, 308);
            this.Name = "Form1";
            this.Text = "Kalkulator Rezystancji";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

