namespace Metodos_Numericos
{
    partial class RungeKutta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RungeKutta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.BtnFormulas = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNi = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.btnReiniciar = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NuI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yRk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFormulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Metodos_Numericos.Properties.Resources.III;
            this.pictureBox4.Location = new System.Drawing.Point(174, 44);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "Método de Runge-Kutta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Metodos_Numericos.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(50, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(682, 88);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Metodos_Numericos.Properties.Resources.Funcion2;
            this.pictureBox3.Location = new System.Drawing.Point(490, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Metodos_Numericos.Properties.Resources.Funcion1;
            this.pictureBox2.Location = new System.Drawing.Point(260, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // tabla
            // 
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeight = 30;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NuI,
            this.Xn,
            this.Yr,
            this.Ye,
            this.Ere,
            this.yEM,
            this.eEm,
            this.yRk,
            this.errR});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle7;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.tabla.Location = new System.Drawing.Point(12, 432);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla.RowHeadersVisible = false;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(829, 191);
            this.tabla.TabIndex = 50;
            // 
            // BtnFormulas
            // 
            this.BtnFormulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFormulas.Image = global::Metodos_Numericos.Properties.Resources.BtnFormula4;
            this.BtnFormulas.Location = new System.Drawing.Point(629, 203);
            this.BtnFormulas.Name = "BtnFormulas";
            this.BtnFormulas.Size = new System.Drawing.Size(156, 33);
            this.BtnFormulas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnFormulas.TabIndex = 49;
            this.BtnFormulas.TabStop = false;
            this.BtnFormulas.Click += new System.EventHandler(this.BtnFormulas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(447, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "N.I";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(447, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Y0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(168, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(168, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "X0";
            // 
            // txtNi
            // 
            this.txtNi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txtNi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNi.ForeColor = System.Drawing.Color.White;
            this.txtNi.Location = new System.Drawing.Point(487, 324);
            this.txtNi.Name = "txtNi";
            this.txtNi.Size = new System.Drawing.Size(200, 26);
            this.txtNi.TabIndex = 44;
            this.txtNi.Text = "4";
            // 
            // txtH
            // 
            this.txtH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txtH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.ForeColor = System.Drawing.Color.White;
            this.txtH.Location = new System.Drawing.Point(208, 324);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(200, 26);
            this.txtH.TabIndex = 43;
            this.txtH.Text = ".5";
            // 
            // txtY0
            // 
            this.txtY0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txtY0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY0.ForeColor = System.Drawing.Color.White;
            this.txtY0.Location = new System.Drawing.Point(487, 265);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(200, 26);
            this.txtY0.TabIndex = 42;
            this.txtY0.Text = "4";
            // 
            // txtX0
            // 
            this.txtX0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txtX0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX0.ForeColor = System.Drawing.Color.White;
            this.txtX0.Location = new System.Drawing.Point(208, 265);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(200, 26);
            this.txtX0.TabIndex = 41;
            this.txtX0.Text = "0";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Image = global::Metodos_Numericos.Properties.Resources.BtnReiniciar;
            this.btnReiniciar.Location = new System.Drawing.Point(448, 376);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(115, 33);
            this.btnReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReiniciar.TabIndex = 40;
            this.btnReiniciar.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Image = global::Metodos_Numericos.Properties.Resources.BtnCalcular;
            this.btnCalcular.Location = new System.Drawing.Point(293, 376);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 34);
            this.btnCalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCalcular.TabIndex = 39;
            this.btnCalcular.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ingrese los Valores:";
            // 
            // NuI
            // 
            this.NuI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.NuI.DefaultCellStyle = dataGridViewCellStyle2;
            this.NuI.HeaderText = "N. Iteraciones";
            this.NuI.Name = "NuI";
            this.NuI.ReadOnly = true;
            this.NuI.Width = 142;
            // 
            // Xn
            // 
            this.Xn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Xn.DefaultCellStyle = dataGridViewCellStyle3;
            this.Xn.HeaderText = "Xn";
            this.Xn.Name = "Xn";
            this.Xn.ReadOnly = true;
            // 
            // Yr
            // 
            this.Yr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Yr.DefaultCellStyle = dataGridViewCellStyle4;
            this.Yr.HeaderText = "y Real";
            this.Yr.Name = "Yr";
            this.Yr.ReadOnly = true;
            // 
            // Ye
            // 
            this.Ye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Ye.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ye.HeaderText = "y Euler";
            this.Ye.Name = "Ye";
            this.Ye.ReadOnly = true;
            // 
            // Ere
            // 
            this.Ere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Ere.DefaultCellStyle = dataGridViewCellStyle6;
            this.Ere.HeaderText = "err Euler";
            this.Ere.Name = "Ere";
            this.Ere.ReadOnly = true;
            // 
            // yEM
            // 
            this.yEM.HeaderText = "y Euler M";
            this.yEM.Name = "yEM";
            this.yEM.ReadOnly = true;
            // 
            // eEm
            // 
            this.eEm.HeaderText = "err Euler M";
            this.eEm.Name = "eEm";
            this.eEm.ReadOnly = true;
            // 
            // yRk
            // 
            this.yRk.HeaderText = "y Ruge";
            this.yRk.Name = "yRk";
            this.yRk.ReadOnly = true;
            // 
            // errR
            // 
            this.errR.HeaderText = "err Runge";
            this.errR.Name = "errR";
            this.errR.ReadOnly = true;
            // 
            // RungeKutta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(853, 660);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.BtnFormulas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNi);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RungeKutta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RungeKutta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFormulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.PictureBox BtnFormulas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNi;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.PictureBox btnReiniciar;
        private System.Windows.Forms.PictureBox btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ere;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn eEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn yRk;
        private System.Windows.Forms.DataGridViewTextBoxColumn errR;
    }
}