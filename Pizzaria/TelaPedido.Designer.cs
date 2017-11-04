namespace Pizzaria
{
    partial class TelaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedido));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTxtCliInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddBebida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bebidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaBdDataSet2 = new Pizzaria.PizzaBdDataSet2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.dgvPizzas = new System.Windows.Forms.DataGridView();
            this.pizzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaBdDataSet1 = new Pizzaria.PizzaBdDataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnMeia = new System.Windows.Forms.RadioButton();
            this.rbtnInteira = new System.Windows.Forms.RadioButton();
            this.pizzaBdDataSet = new Pizzaria.PizzaBdDataSet();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Pizzaria.PizzaBdDataSetTableAdapters.PedidoTableAdapter();
            this.pizzaTableAdapter = new Pizzaria.PizzaBdDataSet1TableAdapters.PizzaTableAdapter();
            this.bebidaTableAdapter = new Pizzaria.PizzaBdDataSet2TableAdapters.BebidaTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.btnFinalizar);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtTotal);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Size = new System.Drawing.Size(886, 450);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizar.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(20, 408);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(253, 30);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(67, 366);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(82, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvPedido);
            this.groupBox2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SlateGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido";
            // 
            // dgvPedido
            // 
            this.dgvPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(6, 35);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(327, 139);
            this.dgvPedido.TabIndex = 0;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rTxtCliInfo);
            this.groupBox1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(41, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Contato";
            // 
            // rTxtCliInfo
            // 
            this.rTxtCliInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rTxtCliInfo.Location = new System.Drawing.Point(7, 19);
            this.rTxtCliInfo.Name = "rTxtCliInfo";
            this.rTxtCliInfo.ReadOnly = true;
            this.rTxtCliInfo.Size = new System.Drawing.Size(279, 73);
            this.rTxtCliInfo.TabIndex = 0;
            this.rTxtCliInfo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(221, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fazer Pedido";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddBebida);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtQtd);
            this.groupBox5.Controls.Add(this.dgvBebidas);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(19, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 143);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bebidas";
            // 
            // btnAddBebida
            // 
            this.btnAddBebida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddBebida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddBebida.Location = new System.Drawing.Point(347, 94);
            this.btnAddBebida.Name = "btnAddBebida";
            this.btnAddBebida.Size = new System.Drawing.Size(98, 32);
            this.btnAddBebida.TabIndex = 3;
            this.btnAddBebida.Text = "Adicionar Pedido";
            this.btnAddBebida.UseVisualStyleBackColor = false;
            this.btnAddBebida.Click += new System.EventHandler(this.btnAddBebida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qtd";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(382, 31);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(63, 23);
            this.txtQtd.TabIndex = 1;
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AutoGenerateColumns = false;
            this.dgvBebidas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.tamanhoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn1});
            this.dgvBebidas.DataSource = this.bebidaBindingSource;
            this.dgvBebidas.Location = new System.Drawing.Point(7, 20);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBebidas.Size = new System.Drawing.Size(331, 106);
            this.dgvBebidas.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn1
            // 
            this.precoDataGridViewTextBoxColumn1.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn1.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn1.Name = "precoDataGridViewTextBoxColumn1";
            // 
            // bebidaBindingSource
            // 
            this.bebidaBindingSource.DataMember = "Bebida";
            this.bebidaBindingSource.DataSource = this.pizzaBdDataSet2;
            // 
            // pizzaBdDataSet2
            // 
            this.pizzaBdDataSet2.DataSetName = "PizzaBdDataSet2";
            this.pizzaBdDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddPizza);
            this.groupBox4.Controls.Add(this.dgvPizzas);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(19, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 204);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sabores";
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPizza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPizza.Location = new System.Drawing.Point(309, 168);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(103, 30);
            this.btnAddPizza.TabIndex = 1;
            this.btnAddPizza.Text = "Adicionar Pedido";
            this.btnAddPizza.UseVisualStyleBackColor = false;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // dgvPizzas
            // 
            this.dgvPizzas.AutoGenerateColumns = false;
            this.dgvPizzas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPizzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizzas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.dgvPizzas.DataSource = this.pizzaBindingSource;
            this.dgvPizzas.Location = new System.Drawing.Point(7, 19);
            this.dgvPizzas.Name = "dgvPizzas";
            this.dgvPizzas.ReadOnly = true;
            this.dgvPizzas.RowTemplate.ReadOnly = true;
            this.dgvPizzas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPizzas.Size = new System.Drawing.Size(438, 133);
            this.dgvPizzas.TabIndex = 0;
            // 
            // pizzaBindingSource
            // 
            this.pizzaBindingSource.DataMember = "Pizza";
            this.pizzaBindingSource.DataSource = this.pizzaBdDataSet1;
            // 
            // pizzaBdDataSet1
            // 
            this.pizzaBdDataSet1.DataSetName = "PizzaBdDataSet1";
            this.pizzaBdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnMeia);
            this.groupBox3.Controls.Add(this.rbtnInteira);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(65, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 39);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // rBtnMeia
            // 
            this.rBtnMeia.AutoSize = true;
            this.rBtnMeia.Location = new System.Drawing.Point(220, 16);
            this.rBtnMeia.Name = "rBtnMeia";
            this.rBtnMeia.Size = new System.Drawing.Size(59, 20);
            this.rBtnMeia.TabIndex = 1;
            this.rBtnMeia.TabStop = true;
            this.rBtnMeia.Text = "Meia";
            this.rBtnMeia.UseVisualStyleBackColor = true;
            // 
            // rbtnInteira
            // 
            this.rbtnInteira.AutoSize = true;
            this.rbtnInteira.Location = new System.Drawing.Point(39, 16);
            this.rbtnInteira.Name = "rbtnInteira";
            this.rbtnInteira.Size = new System.Drawing.Size(74, 20);
            this.rbtnInteira.TabIndex = 0;
            this.rbtnInteira.TabStop = true;
            this.rbtnInteira.Text = "Inteira";
            this.rbtnInteira.UseVisualStyleBackColor = true;
            // 
            // pizzaBdDataSet
            // 
            this.pizzaBdDataSet.DataSetName = "PizzaBdDataSet";
            this.pizzaBdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.pizzaBdDataSet;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // pizzaTableAdapter
            // 
            this.pizzaTableAdapter.ClearBeforeFill = true;
            // 
            // bebidaTableAdapter
            // 
            this.bebidaTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 245;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Width = 50;
            // 
            // TelaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 474);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPedido";
            this.Text = "TelaPedido";
            this.Load += new System.EventHandler(this.TelaPedido_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddBebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.DataGridView dgvPizzas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnMeia;
        private System.Windows.Forms.RadioButton rbtnInteira;
        private System.Windows.Forms.RichTextBox rTxtCliInfo;
        private PizzaBdDataSet pizzaBdDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private PizzaBdDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private PizzaBdDataSet1 pizzaBdDataSet1;
        private System.Windows.Forms.BindingSource pizzaBindingSource;
        private PizzaBdDataSet1TableAdapters.PizzaTableAdapter pizzaTableAdapter;
        private PizzaBdDataSet2 pizzaBdDataSet2;
        private System.Windows.Forms.BindingSource bebidaBindingSource;
        private PizzaBdDataSet2TableAdapters.BebidaTableAdapter bebidaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
    }
}