
namespace proyectoFinal_EnocSibaja
{
    partial class buscarProducto
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
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.can = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.mLimpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.Color.Teal;
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.nombre,
            this.can,
            this.precio,
            this.desc});
            this.lv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(38, 170);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(632, 212);
            this.lv.TabIndex = 38;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo";
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 155;
            // 
            // can
            // 
            this.can.Text = "Cantidad";
            this.can.Width = 78;
            // 
            // precio
            // 
            this.precio.Text = "Precio";
            this.precio.Width = 89;
            // 
            // desc
            // 
            this.desc.Text = "Descripcion";
            this.desc.Width = 236;
            // 
            // codProd
            // 
            this.codProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codProd.Location = new System.Drawing.Point(349, 111);
            this.codProd.Name = "codProd";
            this.codProd.Size = new System.Drawing.Size(200, 24);
            this.codProd.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(165, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Codigo de Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(291, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Buscar Producto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBuscar,
            this.mLimpiar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 25);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mBuscar
            // 
            this.mBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBuscar.Name = "mBuscar";
            this.mBuscar.Size = new System.Drawing.Size(168, 21);
            this.mBuscar.Text = "|| BUSCAR PRODUCTO ||";
            this.mBuscar.Click += new System.EventHandler(this.mBuscar_Click);
            // 
            // mLimpiar
            // 
            this.mLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLimpiar.Name = "mLimpiar";
            this.mLimpiar.Size = new System.Drawing.Size(169, 21);
            this.mLimpiar.Text = "|| LIMPIAR BUSQUEDA ||";
            this.mLimpiar.Click += new System.EventHandler(this.mLimpiar_Click);
            // 
            // buscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoFinal_EnocSibaja.Properties.Resources.ferr_princp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 425);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.codProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "buscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader can;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.TextBox codProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mBuscar;
        private System.Windows.Forms.ToolStripMenuItem mLimpiar;
    }
}