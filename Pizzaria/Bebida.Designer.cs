namespace Pizzaria
{
    partial class Bebida
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bebida));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bebidaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaBdDataSet4 = new Pizzaria.PizzaBdDataSet4();
            this.pizzaBdDataSet2 = new Pizzaria.PizzaBdDataSet2();
            this.bebidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bebidaTableAdapter = new Pizzaria.PizzaBdDataSet2TableAdapters.BebidaTableAdapter();
            this.Formulario = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblLitro = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pizzaBdDataSet3 = new Pizzaria.PizzaBdDataSet3();
            this.bebidaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bebidaTableAdapter1 = new Pizzaria.PizzaBdDataSet3TableAdapters.BebidaTableAdapter();
            this.bebidaTableAdapter2 = new Pizzaria.PizzaBdDataSet4TableAdapters.BebidaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource)).BeginInit();
            this.Formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBebidas);
            this.groupBox1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(16, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bebidas";
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AutoGenerateColumns = false;
            this.dgvBebidas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.dgvBebidas.DataSource = this.bebidaBindingSource2;
            this.dgvBebidas.Location = new System.Drawing.Point(7, 20);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBebidas.Size = new System.Drawing.Size(500, 137);
            this.dgvBebidas.TabIndex = 0;
            this.dgvBebidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBebidas_CellContentClick);
            this.dgvBebidas.Click += new System.EventHandler(this.dgvBebidas_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // bebidaBindingSource2
            // 
            this.bebidaBindingSource2.DataMember = "Bebida";
            this.bebidaBindingSource2.DataSource = this.pizzaBdDataSet4;
            // 
            // pizzaBdDataSet4
            // 
            this.pizzaBdDataSet4.DataSetName = "PizzaBdDataSet4";
            this.pizzaBdDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzaBdDataSet2
            // 
            this.pizzaBdDataSet2.DataSetName = "PizzaBdDataSet2";
            this.pizzaBdDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bebidaBindingSource
            // 
            this.bebidaBindingSource.DataMember = "Bebida";
            this.bebidaBindingSource.DataSource = this.pizzaBdDataSet2;
            // 
            // bebidaTableAdapter
            // 
            this.bebidaTableAdapter.ClearBeforeFill = true;
            // 
            // Formulario
            // 
            this.Formulario.BackColor = System.Drawing.Color.Transparent;
            this.Formulario.Controls.Add(this.pictureBox1);
            this.Formulario.Controls.Add(this.btnIncluir);
            this.Formulario.Controls.Add(this.btnExcluir);
            this.Formulario.Controls.Add(this.btnAlterar);
            this.Formulario.Controls.Add(this.txtPreco);
            this.Formulario.Controls.Add(this.txtLitros);
            this.Formulario.Controls.Add(this.txtTipo);
            this.Formulario.Controls.Add(this.lblLitro);
            this.Formulario.Controls.Add(this.lblPreco);
            this.Formulario.Controls.Add(this.lblTipo);
            this.Formulario.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Formulario.Location = new System.Drawing.Point(16, 16);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(506, 231);
            this.Formulario.TabIndex = 2;
            this.Formulario.TabStop = false;
            this.Formulario.Text = "Formulario";
            this.Formulario.Enter += new System.EventHandler(this.Formulario_Enter);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncluir.ForeColor = System.Drawing.Color.Black;
            this.btnIncluir.Location = new System.Drawing.Point(16, 180);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(85, 32);
            this.btnIncluir.TabIndex = 65;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(205, 180);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 32);
            this.btnExcluir.TabIndex = 64;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Location = new System.Drawing.Point(107, 180);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 32);
            this.btnAlterar.TabIndex = 63;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(89, 128);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(198, 23);
            this.txtPreco.TabIndex = 62;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(89, 91);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(198, 23);
            this.txtLitros.TabIndex = 60;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(89, 52);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(198, 23);
            this.txtTipo.TabIndex = 59;
            // 
            // lblLitro
            // 
            this.lblLitro.AutoSize = true;
            this.lblLitro.Location = new System.Drawing.Point(18, 91);
            this.lblLitro.Name = "lblLitro";
            this.lblLitro.Size = new System.Drawing.Size(33, 16);
            this.lblLitro.TabIndex = 58;
            this.lblLitro.Text = "Qtd";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(18, 131);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(51, 16);
            this.lblPreco.TabIndex = 57;
            this.lblPreco.Text = "Preço:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(18, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(52, 16);
            this.lblTipo.TabIndex = 55;
            this.lblTipo.Text = "Nome:";
            // 
            // pizzaBdDataSet3
            // 
            this.pizzaBdDataSet3.DataSetName = "PizzaBdDataSet3";
            this.pizzaBdDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bebidaBindingSource1
            // 
            this.bebidaBindingSource1.DataMember = "Bebida";
            this.bebidaBindingSource1.DataSource = this.pizzaBdDataSet3;
            // 
            // bebidaTableAdapter1
            // 
            this.bebidaTableAdapter1.ClearBeforeFill = true;
            // 
            // bebidaTableAdapter2
            // 
            this.bebidaTableAdapter2.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Formulario);
            this.panel1.Location = new System.Drawing.Point(133, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 440);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(322, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 160);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // Bebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bebida";
            this.Text = "Bebida";
            this.Load += new System.EventHandler(this.Bebida_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource)).EndInit();
            this.Formulario.ResumeLayout(false);
            this.Formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBebidas;
        private PizzaBdDataSet2 pizzaBdDataSet2;
        private System.Windows.Forms.BindingSource bebidaBindingSource;
        private PizzaBdDataSet2TableAdapters.BebidaTableAdapter bebidaTableAdapter;
        private System.Windows.Forms.GroupBox Formulario;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblLitro;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblTipo;
        private PizzaBdDataSet3 pizzaBdDataSet3;
        private System.Windows.Forms.BindingSource bebidaBindingSource1;
        private PizzaBdDataSet3TableAdapters.BebidaTableAdapter bebidaTableAdapter1;
        private PizzaBdDataSet4 pizzaBdDataSet4;
        private System.Windows.Forms.BindingSource bebidaBindingSource2;
        private PizzaBdDataSet4TableAdapters.BebidaTableAdapter bebidaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}