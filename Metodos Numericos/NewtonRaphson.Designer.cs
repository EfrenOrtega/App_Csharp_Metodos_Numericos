namespace Metodos_Numericos
{
    partial class NewtonRaphson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewtonRaphson));
            this.tabla = new System.Windows.Forms.DataGridView();
            this.NuI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnFormulas = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFormulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tabla.ColumnHeadersHeight = 30;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NuI,
            this.Xn,
            this.Yr,
            this.Ye,
            this.Ere});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle21;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.tabla.Location = new System.Drawing.Point(12, 435);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla.RowHeadersVisible = false;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(829, 191);
            this.tabla.TabIndex = 68;
            // 
            // NuI
            // 
            this.NuI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.NuI.DefaultCellStyle = dataGridViewCellStyle16;
            this.NuI.HeaderText = "N. Iteraciones";
            this.NuI.Name = "NuI";
            this.NuI.ReadOnly = true;
            this.NuI.Width = 142;
            // 
            // Xn
            // 
            this.Xn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.Xn.DefaultCellStyle = dataGridViewCellStyle17;
            this.Xn.HeaderText = "Xn";
            this.Xn.Name = "Xn";
            this.Xn.ReadOnly = true;
            // 
            // Yr
            // 
            this.Yr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.Yr.DefaultCellStyle = dataGridViewCellStyle18;
            this.Yr.HeaderText = "f(Xn)";
            this.Yr.Name = "Yr";
            this.Yr.ReadOnly = true;
            // 
            // Ye
            // 
            this.Ye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.Ye.DefaultCellStyle = dataGridViewCellStyle19;
            this.Ye.HeaderText = "f\'(Xn)";
            this.Ye.Name = "Ye";
            this.Ye.ReadOnly = true;
            // 
            // Ere
            // 
            this.Ere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.Ere.DefaultCellStyle = dataGridViewCellStyle20;
            this.Ere.HeaderText = "|Xn - Xn-1|";
            this.Ere.Name = "Ere";
            this.Ere.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(168, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = "X0";
            // 
            // txtX0
            // 
            this.txtX0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txtX0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX0.ForeColor = System.Drawing.Color.White;
            this.txtX0.Location = new System.Drawing.Point(208, 319);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(470, 26);
            this.txtX0.TabIndex = 59;
            this.txtX0.Text = "0.75";
            this.txtX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ingrese los Valores:";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(682, 96);
            this.label3.TabIndex = 55;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 44);
            this.label2.TabIndex = 53;
            this.label2.Text = "Método de Newton Raphson";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Metodos_Numericos.Properties.Resources.f_x_Newton;
            this.pictureBox3.Location = new System.Drawing.Point(493, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Metodos_Numericos.Properties.Resources.fx_Netwon;
            this.pictureBox2.Location = new System.Drawing.Point(229, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // BtnFormulas
            // 
            this.BtnFormulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFormulas.Image = global::Metodos_Numericos.Properties.Resources.BtnFormula4;
            this.BtnFormulas.Location = new System.Drawing.Point(629, 206);
            this.BtnFormulas.Name = "BtnFormulas";
            this.BtnFormulas.Size = new System.Drawing.Size(156, 33);
            this.BtnFormulas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnFormulas.TabIndex = 67;
            this.BtnFormulas.TabStop = false;
            this.BtnFormulas.Click += new System.EventHandler(this.BtnFormulas_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Image = global::Metodos_Numericos.Properties.Resources.BtnReiniciar;
            this.btnReiniciar.Location = new System.Drawing.Point(448, 379);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(115, 33);
            this.btnReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReiniciar.TabIndex = 58;
            this.btnReiniciar.TabStop = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Image = global::Metodos_Numericos.Properties.Resources.BtnCalcular;
            this.btnCalcular.Location = new System.Drawing.Point(293, 379);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 34);
            this.btnCalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCalcular.TabIndex = 57;
            this.btnCalcular.TabStop = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Metodos_Numericos.Properties.Resources.IV;
            this.pictureBox4.Location = new System.Drawing.Point(153, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Metodos_Numericos.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(50, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NewtonRaphson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(853, 660);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.BtnFormulas);
            this.Controls.Add(this.label5);
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
            this.Name = "NewtonRaphson";
            this.Text = "NewtonRaphson";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFormulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.PictureBox BtnFormulas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.PictureBox btnReiniciar;
        private System.Windows.Forms.PictureBox btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ere;
    }
}