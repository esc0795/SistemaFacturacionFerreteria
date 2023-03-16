
namespace proyectoFinal_EnocSibaja
{
    partial class borrarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codProd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gUARDARPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSCARPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIMPIARBUSQUEDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lv = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.can = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(313, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Borrar Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(73, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo de Producto:";
            // 
            // codProd
            // 
            this.codProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codProd.Location = new System.Drawing.Point(243, 113);
            this.codProd.Name = "codProd";
            this.codProd.Size = new System.Drawing.Size(200, 24);
            this.codProd.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gUARDARPRODUCTOToolStripMenuItem,
            this.bUSCARPRODUCTOToolStripMenuItem,
            this.lIMPIARBUSQUEDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 25);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gUARDARPRODUCTOToolStripMenuItem
            // 
            this.gUARDARPRODUCTOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gUARDARPRODUCTOToolStripMenuItem.Name = "gUARDARPRODUCTOToolStripMenuItem";
            this.gUARDARPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(180, 21);
            this.gUARDARPRODUCTOToolStripMenuItem.Text = "|| ELIMINAR PRODUCTO ||";
            this.gUARDARPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.gUARDARPRODUCTOToolStripMenuItem_Click);
            // 
            // bUSCARPRODUCTOToolStripMenuItem
            // 
            this.bUSCARPRODUCTOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUSCARPRODUCTOToolStripMenuItem.Name = "bUSCARPRODUCTOToolStripMenuItem";
            this.bUSCARPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(168, 21);
            this.bUSCARPRODUCTOToolStripMenuItem.Text = "|| BUSCAR PRODUCTO ||";
            this.bUSCARPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.bUSCARPRODUCTOToolStripMenuItem_Click);
            // 
            // lIMPIARBUSQUEDAToolStripMenuItem
            // 
            this.lIMPIARBUSQUEDAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIMPIARBUSQUEDAToolStripMenuItem.Name = "lIMPIARBUSQUEDAToolStripMenuItem";
            this.lIMPIARBUSQUEDAToolStripMenuItem.Size = new System.Drawing.Size(169, 21);
            this.lIMPIARBUSQUEDAToolStripMenuItem.Text = "|| LIMPIAR BUSQUEDA ||";
            this.lIMPIARBUSQUEDAToolStripMenuItem.Click += new System.EventHandler(this.lIMPIARBUSQUEDAToolStripMenuItem_Click);
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
            this.lv.Location = new System.Drawing.Point(37, 185);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(642, 183);
            this.lv.TabIndex = 39;
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
            this.nombre.Width = 159;
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
            this.desc.Width = 245;
            // 
            // borrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoFinal_EnocSibaja.Properties.Resources.ferr_princp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 409);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.codProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "borrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar Producto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codProd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gUARDARPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSCARPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIMPIARBUSQUEDAToolStripMenuItem;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader can;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.ColumnHeader desc;
    }
}