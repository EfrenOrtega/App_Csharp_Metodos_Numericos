﻿namespace Metodos_Numericos
{
    partial class EulerMejorado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EulerMejorado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNi = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.NuI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnVerFormulas = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerFormulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Método de Euler Mejorado";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(682, 88);
            this.label3.TabIndex = 9;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(447, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 33;
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
            this.label7.TabIndex = 32;
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
            this.label6.TabIndex = 31;
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
            this.label5.TabIndex = 30;
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
            this.txtNi.TabIndex = 29;
            this.txtNi.Text = "4";
            this.txtNi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNi_KeyPress);
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
            this.txtH.TabIndex = 28;
            this.txtH.Text = ".5";
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
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
            this.txtY0.TabIndex = 27;
            this.txtY0.Text = "4";
            this.txtY0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY0_KeyPress);
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
            this.txtX0.TabIndex = 26;
            this.txtX0.Text = "0";
            this.txtX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ingrese los Valores:";
            // 
            // tabla
            // 
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tabla.ColumnHeadersHeight = 30;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NuI,
            this.Xn,
            this.Yr,
            this.Ye,
            this.Ere,
            this.yEm,
            this.errEM});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle14;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.tabla.Location = new System.Drawing.Point(71, 432);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla.RowHeadersVisible = false;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(712, 191);
            this.tabla.TabIndex = 35;
            // 
            // NuI
            // 
            this.NuI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.NuI.DefaultCellStyle = dataGridViewCellStyle9;
            this.NuI.HeaderText = "N. Iteraciones";
            this.NuI.Name = "NuI";
            this.NuI.ReadOnly = true;
            this.NuI.Width = 142;
            // 
            // Xn
            // 
            this.Xn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Xn.DefaultCellStyle = dataGridViewCellStyle10;
            this.Xn.HeaderText = "Xn";
            this.Xn.Name = "Xn";
            this.Xn.ReadOnly = true;
            // 
            // Yr
            // 
            this.Yr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Yr.DefaultCellStyle = dataGridViewCellStyle11;
            this.Yr.HeaderText = "y Real";
            this.Yr.Name = "Yr";
            this.Yr.ReadOnly = true;
            // 
            // Ye
            // 
            this.Ye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Ye.DefaultCellStyle = dataGridViewCellStyle12;
            this.Ye.HeaderText = "y Euler";
            this.Ye.Name = "Ye";
            this.Ye.ReadOnly = true;
            // 
            // Ere
            // 
            this.Ere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.Ere.DefaultCellStyle = dataGridViewCellStyle13;
            this.Ere.HeaderText = "err Euler";
            this.Ere.Name = "Ere";
            this.Ere.ReadOnly = true;
            // 
            // yEm
            // 
            this.yEm.HeaderText = "y Euler M";
            this.yEm.Name = "yEm";
            this.yEm.ReadOnly = true;
            // 
            // errEM
            // 
            this.errEM.HeaderText = "err Euler M";
            this.errEM.Name = "errEM";
            this.errEM.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Metodos_Numericos.Properties.Resources.Funcion1;
            this.pictureBox2.Location = new System.Drawing.Point(260, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // BtnVerFormulas
            // 
            this.BtnVerFormulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerFormulas.Image = global::Metodos_Numericos.Properties.Resources.BtnFormula4;
            this.BtnVerFormulas.Location = new System.Drawing.Point(629, 203);
            this.BtnVerFormulas.Name = "BtnVerFormulas";
            this.BtnVerFormulas.Size = new System.Drawing.Size(156, 33);
            this.BtnVerFormulas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnVerFormulas.TabIndex = 34;
            this.BtnVerFormulas.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Image = global::Metodos_Numericos.Properties.Resources.BtnReiniciar;
            this.btnReiniciar.Location = new System.Drawing.Point(448, 376);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(115, 33);
            this.btnReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReiniciar.TabIndex = 25;
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
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Metodos_Numericos.Properties.Resources.II;
            this.pictureBox4.Location = new System.Drawing.Point(164, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegresar.Image = global::Metodos_Numericos.Properties.Resources.Back;
            this.BtnRegresar.Location = new System.Drawing.Point(50, 22);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(52, 50);
            this.BtnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnRegresar.TabIndex = 0;
            this.BtnRegresar.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Metodos_Numericos.Properties.Resources.Funcion2;
            this.pictureBox3.Location = new System.Drawing.Point(490, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // EulerMejorado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(853, 660);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.BtnVerFormulas);
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
            this.Controls.Add(this.BtnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EulerMejorado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EulerMejorado";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerFormulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ere;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn errEM;
        public System.Windows.Forms.PictureBox btnCalcular;
        public System.Windows.Forms.TextBox txtNi;
        public System.Windows.Forms.TextBox txtH;
        public System.Windows.Forms.TextBox txtY0;
        public System.Windows.Forms.TextBox txtX0;
        public System.Windows.Forms.DataGridView tabla;
        public System.Windows.Forms.PictureBox BtnVerFormulas;
        public System.Windows.Forms.PictureBox BtnRegresar;
        public System.Windows.Forms.PictureBox btnReiniciar;
    }
}