
namespace proyectoFinal_EnocSibaja
{
    partial class eliminarOrden
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
            this.label2 = new System.Windows.Forms.Label();
            this.codProd = new System.Windows.Forms.TextBox();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.lIMPIARBUSQUEDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(69, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Codigo de Producto:";
            // 
            // codProd
            // 
            this.codProd.Location = new System.Drawing.Point(239, 109);
            this.codProd.Name = "codProd";
            this.codProd.Size = new System.Drawing.Size(132, 20);
            this.codProd.TabIndex = 28;
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.lv.ForeColor = System.Drawing.SystemColors.Window;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(25, 150);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(532, 154);
            this.lv.TabIndex = 27;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo Producto";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(162, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Buscar Orden";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarMenu,
            this.limpiar,
            this.lIMPIARBUSQUEDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 25);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarMenu
            // 
            this.buscarMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarMenu.Name = "buscarMenu";
            this.buscarMenu.Size = new System.Drawing.Size(154, 21);
            this.buscarMenu.Text = "|| ELIMINAR ORDEN ||";
            this.buscarMenu.Click += new System.EventHandler(this.buscarMenu_Click);
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(93, 21);
            this.limpiar.Text = "|| BUSCAR ||";
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // lIMPIARBUSQUEDAToolStripMenuItem
            // 
            this.lIMPIARBUSQUEDAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIMPIARBUSQUEDAToolStripMenuItem.Name = "lIMPIARBUSQUEDAToolStripMenuItem";
            this.lIMPIARBUSQUEDAToolStripMenuItem.Size = new System.Drawing.Size(157, 21);
            this.lIMPIARBUSQUEDAToolStripMenuItem.Text = "|| LIMPIAR BUSQUEDA ||";
            this.lIMPIARBUSQUEDAToolStripMenuItem.Click += new System.EventHandler(this.lIMPIARBUSQUEDAToolStripMenuItem_Click);
            // 
            // eliminarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoFinal_EnocSibaja.Properties.Resources.ferr_princp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 326);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codProd);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.label1);
            this.Name = "eliminarOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Orden";
            this.Load += new System.EventHandler(this.eliminarOrden_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codProd;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarMenu;
        private System.Windows.Forms.ToolStripMenuItem limpiar;
        private System.Windows.Forms.ToolStripMenuItem lIMPIARBUSQUEDAToolStripMenuItem;
    }
}