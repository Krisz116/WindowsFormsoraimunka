namespace WindowsFormsoraimunka
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
            this.azonosito = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.szuletetsido = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.szuletesihely = new System.Windows.Forms.ComboBox();
            this.angol = new System.Windows.Forms.RadioButton();
            this.nemet = new System.Windows.Forms.RadioButton();
            this.francia = new System.Windows.Forms.RadioButton();
            this.olasz = new System.Windows.Forms.RadioButton();
            this.ellenorzes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.azonosito)).BeginInit();
            this.SuspendLayout();
            // 
            // azonosito
            // 
            this.azonosito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azonosito.Location = new System.Drawing.Point(99, 12);
            this.azonosito.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.azonosito.Name = "azonosito";
            this.azonosito.Size = new System.Drawing.Size(150, 26);
            this.azonosito.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // nev
            // 
            this.nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nev.Location = new System.Drawing.Point(99, 49);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(150, 26);
            this.nev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Születet";
            // 
            // szuletetsido
            // 
            this.szuletetsido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuletetsido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.szuletetsido.Location = new System.Drawing.Point(81, 265);
            this.szuletetsido.Name = "szuletetsido";
            this.szuletetsido.Size = new System.Drawing.Size(131, 26);
            this.szuletetsido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(-3, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hol Született";
            // 
            // szuletesihely
            // 
            this.szuletesihely.FormattingEnabled = true;
            this.szuletesihely.Items.AddRange(new object[] {
            "Debrecen",
            "Budapest",
            "Győr",
            "Miskolc",
            "Nyiregyháza",
            "Szolnok",
            "Keszthely",
            "Siófok"});
            this.szuletesihely.Location = new System.Drawing.Point(118, 330);
            this.szuletesihely.Name = "szuletesihely";
            this.szuletesihely.Size = new System.Drawing.Size(121, 21);
            this.szuletesihely.TabIndex = 7;
            // 
            // angol
            // 
            this.angol.AutoSize = true;
            this.angol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angol.Location = new System.Drawing.Point(117, 163);
            this.angol.Name = "angol";
            this.angol.Size = new System.Drawing.Size(68, 24);
            this.angol.TabIndex = 9;
            this.angol.TabStop = true;
            this.angol.Text = "Angol";
            this.angol.UseVisualStyleBackColor = true;
            // 
            // nemet
            // 
            this.nemet.AutoSize = true;
            this.nemet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nemet.Location = new System.Drawing.Point(24, 109);
            this.nemet.Name = "nemet";
            this.nemet.Size = new System.Drawing.Size(74, 24);
            this.nemet.TabIndex = 10;
            this.nemet.TabStop = true;
            this.nemet.Text = "Német";
            this.nemet.UseVisualStyleBackColor = true;
            // 
            // francia
            // 
            this.francia.AutoSize = true;
            this.francia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.francia.Location = new System.Drawing.Point(24, 163);
            this.francia.Name = "francia";
            this.francia.Size = new System.Drawing.Size(80, 24);
            this.francia.TabIndex = 11;
            this.francia.TabStop = true;
            this.francia.Text = "Francia";
            this.francia.UseVisualStyleBackColor = true;
            // 
            // olasz
            // 
            this.olasz.AutoSize = true;
            this.olasz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.olasz.Location = new System.Drawing.Point(118, 109);
            this.olasz.Name = "olasz";
            this.olasz.Size = new System.Drawing.Size(67, 24);
            this.olasz.TabIndex = 12;
            this.olasz.TabStop = true;
            this.olasz.Text = "Olasz";
            this.olasz.UseVisualStyleBackColor = true;
            // 
            // ellenorzes
            // 
            this.ellenorzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ellenorzes.Location = new System.Drawing.Point(1, 381);
            this.ellenorzes.Name = "ellenorzes";
            this.ellenorzes.Size = new System.Drawing.Size(102, 57);
            this.ellenorzes.TabIndex = 13;
            this.ellenorzes.Text = "Ellenörzés";
            this.ellenorzes.UseVisualStyleBackColor = true;
            this.ellenorzes.Click += new System.EventHandler(this.ellenorzes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.francia);
            this.Controls.Add(this.angol);
            this.Controls.Add(this.olasz);
            this.Controls.Add(this.nemet);
            this.Controls.Add(this.ellenorzes);
            this.Controls.Add(this.szuletesihely);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.szuletetsido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.azonosito);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.azonosito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown azonosito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker szuletetsido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox szuletesihely;
        private System.Windows.Forms.RadioButton angol;
        private System.Windows.Forms.RadioButton nemet;
        private System.Windows.Forms.RadioButton francia;
        private System.Windows.Forms.RadioButton olasz;
        private System.Windows.Forms.Button ellenorzes;
    }
}

