namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.A1BT = new System.Windows.Forms.Button();
            this.B1BT = new System.Windows.Forms.Button();
            this.C1BT = new System.Windows.Forms.Button();
            this.A2BT = new System.Windows.Forms.Button();
            this.B2BT = new System.Windows.Forms.Button();
            this.C2BT = new System.Windows.Forms.Button();
            this.A3BT = new System.Windows.Forms.Button();
            this.B3BT = new System.Windows.Forms.Button();
            this.C3BT = new System.Windows.Forms.Button();
            this.rePlay = new System.Windows.Forms.Button();
            this.AIBrainLB = new System.Windows.Forms.Label();
            this.consoleLB = new System.Windows.Forms.ListView();
            this.consoleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A1BT
            // 
            this.A1BT.BackColor = System.Drawing.Color.Lime;
            this.A1BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1BT.Location = new System.Drawing.Point(12, 12);
            this.A1BT.Name = "A1BT";
            this.A1BT.Size = new System.Drawing.Size(100, 100);
            this.A1BT.TabIndex = 0;
            this.A1BT.TabStop = false;
            this.A1BT.UseVisualStyleBackColor = false;
            this.A1BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // B1BT
            // 
            this.B1BT.BackColor = System.Drawing.Color.Lime;
            this.B1BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1BT.Location = new System.Drawing.Point(118, 12);
            this.B1BT.Name = "B1BT";
            this.B1BT.Size = new System.Drawing.Size(100, 100);
            this.B1BT.TabIndex = 1;
            this.B1BT.TabStop = false;
            this.B1BT.UseVisualStyleBackColor = false;
            this.B1BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // C1BT
            // 
            this.C1BT.BackColor = System.Drawing.Color.Lime;
            this.C1BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1BT.Location = new System.Drawing.Point(224, 12);
            this.C1BT.Name = "C1BT";
            this.C1BT.Size = new System.Drawing.Size(100, 100);
            this.C1BT.TabIndex = 2;
            this.C1BT.TabStop = false;
            this.C1BT.UseVisualStyleBackColor = false;
            this.C1BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // A2BT
            // 
            this.A2BT.BackColor = System.Drawing.Color.Lime;
            this.A2BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2BT.Location = new System.Drawing.Point(12, 118);
            this.A2BT.Name = "A2BT";
            this.A2BT.Size = new System.Drawing.Size(100, 100);
            this.A2BT.TabIndex = 3;
            this.A2BT.TabStop = false;
            this.A2BT.UseVisualStyleBackColor = false;
            this.A2BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // B2BT
            // 
            this.B2BT.BackColor = System.Drawing.Color.Lime;
            this.B2BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2BT.Location = new System.Drawing.Point(118, 118);
            this.B2BT.Name = "B2BT";
            this.B2BT.Size = new System.Drawing.Size(100, 100);
            this.B2BT.TabIndex = 4;
            this.B2BT.TabStop = false;
            this.B2BT.UseVisualStyleBackColor = false;
            this.B2BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // C2BT
            // 
            this.C2BT.BackColor = System.Drawing.Color.Lime;
            this.C2BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2BT.Location = new System.Drawing.Point(224, 118);
            this.C2BT.Name = "C2BT";
            this.C2BT.Size = new System.Drawing.Size(100, 100);
            this.C2BT.TabIndex = 5;
            this.C2BT.TabStop = false;
            this.C2BT.UseVisualStyleBackColor = false;
            this.C2BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // A3BT
            // 
            this.A3BT.BackColor = System.Drawing.Color.Lime;
            this.A3BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3BT.Location = new System.Drawing.Point(12, 224);
            this.A3BT.Name = "A3BT";
            this.A3BT.Size = new System.Drawing.Size(100, 100);
            this.A3BT.TabIndex = 6;
            this.A3BT.TabStop = false;
            this.A3BT.UseVisualStyleBackColor = false;
            this.A3BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // B3BT
            // 
            this.B3BT.BackColor = System.Drawing.Color.Lime;
            this.B3BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3BT.Location = new System.Drawing.Point(118, 224);
            this.B3BT.Name = "B3BT";
            this.B3BT.Size = new System.Drawing.Size(100, 100);
            this.B3BT.TabIndex = 7;
            this.B3BT.TabStop = false;
            this.B3BT.UseVisualStyleBackColor = false;
            this.B3BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // C3BT
            // 
            this.C3BT.BackColor = System.Drawing.Color.Lime;
            this.C3BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3BT.Location = new System.Drawing.Point(224, 224);
            this.C3BT.Name = "C3BT";
            this.C3BT.Size = new System.Drawing.Size(100, 100);
            this.C3BT.TabIndex = 8;
            this.C3BT.TabStop = false;
            this.C3BT.UseVisualStyleBackColor = false;
            this.C3BT.Click += new System.EventHandler(this.Cell_Click);
            // 
            // rePlay
            // 
            this.rePlay.Location = new System.Drawing.Point(330, 12);
            this.rePlay.Name = "rePlay";
            this.rePlay.Size = new System.Drawing.Size(144, 23);
            this.rePlay.TabIndex = 9;
            this.rePlay.Text = "Play";
            this.rePlay.UseVisualStyleBackColor = true;
            this.rePlay.Click += new System.EventHandler(this.rePlay_Click);
            // 
            // AIBrainLB
            // 
            this.AIBrainLB.AutoSize = true;
            this.AIBrainLB.ForeColor = System.Drawing.Color.DarkBlue;
            this.AIBrainLB.Location = new System.Drawing.Point(330, 308);
            this.AIBrainLB.Name = "AIBrainLB";
            this.AIBrainLB.Size = new System.Drawing.Size(63, 13);
            this.AIBrainLB.TabIndex = 11;
            this.AIBrainLB.Text = "AI is waiting";
            // 
            // consoleLB
            // 
            this.consoleLB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.consoleHeader});
            this.consoleLB.FullRowSelect = true;
            this.consoleLB.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.consoleLB.Location = new System.Drawing.Point(330, 68);
            this.consoleLB.Name = "consoleLB";
            this.consoleLB.ShowGroups = false;
            this.consoleLB.Size = new System.Drawing.Size(144, 237);
            this.consoleLB.TabIndex = 12;
            this.consoleLB.TabStop = false;
            this.consoleLB.UseCompatibleStateImageBehavior = false;
            this.consoleLB.View = System.Windows.Forms.View.Details;
            // 
            // consoleHeader
            // 
            this.consoleHeader.Text = "Console";
            this.consoleHeader.Width = 122;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Player",
            "AI"});
            this.comboBox1.Location = new System.Drawing.Point(365, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Start";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.consoleLB);
            this.Controls.Add(this.AIBrainLB);
            this.Controls.Add(this.rePlay);
            this.Controls.Add(this.C3BT);
            this.Controls.Add(this.B3BT);
            this.Controls.Add(this.A3BT);
            this.Controls.Add(this.C2BT);
            this.Controls.Add(this.B2BT);
            this.Controls.Add(this.A2BT);
            this.Controls.Add(this.C1BT);
            this.Controls.Add(this.B1BT);
            this.Controls.Add(this.A1BT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.Text = "TicTacToe by CrashZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1BT;
        private System.Windows.Forms.Button B1BT;
        private System.Windows.Forms.Button C1BT;
        private System.Windows.Forms.Button A2BT;
        private System.Windows.Forms.Button B2BT;
        private System.Windows.Forms.Button C2BT;
        private System.Windows.Forms.Button A3BT;
        private System.Windows.Forms.Button B3BT;
        private System.Windows.Forms.Button C3BT;
        private System.Windows.Forms.Button rePlay;
        private System.Windows.Forms.Label AIBrainLB;
        private System.Windows.Forms.ListView consoleLB;
        private System.Windows.Forms.ColumnHeader consoleHeader;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

