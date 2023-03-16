
namespace proyectoFinal_EnocSibaja
{
    partial class crearFactura
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
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.lIMPIARBUSQUEDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecFac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numFac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idArt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.canProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.corrFac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.telFac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.impuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.subTot = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totFin = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv.ForeColor = System.Drawing.SystemColors.Window;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(29, 283);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(704, 214);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cantidad";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Detalle";
            this.columnHeader2.Width = 327;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio Unitario";
            this.columnHeader3.Width = 142;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 96;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarMenu,
            this.limpiar,
            this.lIMPIARBUSQUEDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 25);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarMenu
            // 
            this.buscarMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarMenu.Name = "buscarMenu";
            this.buscarMenu.Size = new System.Drawing.Size(170, 21);
            this.buscarMenu.Text = "|| AGREGAR ARTICULO ||";
            this.buscarMenu.Click += new System.EventHandler(this.buscarMenu_Click);
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(171, 21);
            this.limpiar.Text = "|| FINALIZAR FACTURA ||";
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // lIMPIARBUSQUEDAToolStripMenuItem
            // 
            this.lIMPIARBUSQUEDAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIMPIARBUSQUEDAToolStripMenuItem.Name = "lIMPIARBUSQUEDAToolStripMenuItem";
            this.lIMPIARBUSQUEDAToolStripMenuItem.Size = new System.Drawing.Size(144, 21);
            this.lIMPIARBUSQUEDAToolStripMenuItem.Text = "|| LIMPIAR FACTURA ||";
            this.lIMPIARBUSQUEDAToolStripMenuItem.Click += new System.EventHandler(this.lIMPIARBUSQUEDAToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(816, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Codigo de Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(385, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha de entrada:";
            // 
            // fecFac
            // 
            this.fecFac.Location = new System.Drawing.Point(534, 51);
            this.fecFac.Name = "fecFac";
            this.fecFac.ReadOnly = true;
            this.fecFac.Size = new System.Drawing.Size(132, 20);
            this.fecFac.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(53, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Numero Factura:";
            // 
            // numFac
            // 
            this.numFac.Location = new System.Drawing.Point(194, 48);
            this.numFac.Name = "numFac";
            this.numFac.Size = new System.Drawing.Size(132, 20);
            this.numFac.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(83, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "ID Articulo:";
            // 
            // idArt
            // 
            this.idArt.Location = new System.Drawing.Point(194, 240);
            this.idArt.Name = "idArt";
            this.idArt.Size = new System.Drawing.Size(132, 20);
            this.idArt.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(385, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cantidad:";
            // 
            // canProd
            // 
            this.canProd.Location = new System.Drawing.Point(470, 238);
            this.canProd.Name = "canProd";
            this.canProd.Size = new System.Drawing.Size(83, 20);
            this.canProd.TabIndex = 40;
            this.canProd.TextChanged += new System.EventHandler(this.canProd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(108, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Correo:";
            // 
            // corrFac
            // 
            this.corrFac.Location = new System.Drawing.Point(194, 115);
            this.corrFac.Name = "corrFac";
            this.corrFac.Size = new System.Drawing.Size(132, 20);
            this.corrFac.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(385, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "Telefono:";
            // 
            // telFac
            // 
            this.telFac.Location = new System.Drawing.Point(486, 115);
            this.telFac.Name = "telFac";
            this.telFac.Size = new System.Drawing.Size(132, 20);
            this.telFac.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(44, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nombre Cliente:";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(194, 172);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(132, 20);
            this.nom.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(44, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "Impuestos:";
            // 
            // impuesto
            // 
            this.impuesto.BackColor = System.Drawing.Color.Black;
            this.impuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.impuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impuesto.ForeColor = System.Drawing.SystemColors.Window;
            this.impuesto.Location = new System.Drawing.Point(141, 572);
            this.impuesto.Name = "impuesto";
            this.impuesto.Size = new System.Drawing.Size(98, 19);
            this.impuesto.TabIndex = 50;
            this.impuesto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Ivory;
            this.label10.Location = new System.Drawing.Point(273, 573);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 51;
            this.label10.Text = "Sub Total:";
            // 
            // subTot
            // 
            this.subTot.BackColor = System.Drawing.Color.Black;
            this.subTot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTot.ForeColor = System.Drawing.SystemColors.Window;
            this.subTot.Location = new System.Drawing.Point(364, 574);
            this.subTot.Name = "subTot";
            this.subTot.Size = new System.Drawing.Size(117, 17);
            this.subTot.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Ivory;
            this.label11.Location = new System.Drawing.Point(531, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "Total:";
            // 
            // totFin
            // 
            this.totFin.BackColor = System.Drawing.Color.Black;
            this.totFin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totFin.ForeColor = System.Drawing.SystemColors.Window;
            this.totFin.Location = new System.Drawing.Point(588, 574);
            this.totFin.Name = "totFin";
            this.totFin.Size = new System.Drawing.Size(117, 17);
            this.totFin.TabIndex = 54;
            // 
            // crearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoFinal_EnocSibaja.Properties.Resources.ferr_princp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 643);
            this.Controls.Add(this.totFin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.subTot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.impuesto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telFac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.corrFac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.canProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numFac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecFac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lv);
            this.Name = "crearFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crearFactura";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarMenu;
        private System.Windows.Forms.ToolStripMenuItem limpiar;
        private System.Windows.Forms.ToolStripMenuItem lIMPIARBUSQUEDAToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fecFac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numFac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox canProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox corrFac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telFac;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox impuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox subTot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totFin;
    }
}