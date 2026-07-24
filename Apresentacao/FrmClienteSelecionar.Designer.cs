namespace Apresentacao
{
    partial class FrmClienteSelecionar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonPesquisar = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            buttonExcluir = new Button();
            buttonConsultar = new Button();
            buttonFechar = new Button();
            dataGridViewPrincipal = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colDataNascimento = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewCheckBoxColumn();
            colLimiteCompra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).BeginInit();
            SuspendLayout();
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(8, 11);
            labelPesquisa.Margin = new Padding(2, 0, 2, 0);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(56, 15);
            labelPesquisa.TabIndex = 0;
            labelPesquisa.Text = "ID/Nome";
            labelPesquisa.Click += label1_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(73, 9);
            textBoxPesquisa.Margin = new Padding(2);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(471, 23);
            textBoxPesquisa.TabIndex = 1;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(550, 8);
            buttonPesquisar.Margin = new Padding(2);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(141, 20);
            buttonPesquisar.TabIndex = 2;
            buttonPesquisar.Text = "&Buscar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(307, 256);
            buttonInserir.Margin = new Padding(2);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(68, 32);
            buttonInserir.TabIndex = 4;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(386, 256);
            buttonAlterar.Margin = new Padding(2);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(68, 32);
            buttonAlterar.TabIndex = 5;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(466, 256);
            buttonExcluir.Margin = new Padding(2);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(68, 32);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(545, 256);
            buttonConsultar.Margin = new Padding(2);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(68, 32);
            buttonConsultar.TabIndex = 7;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            buttonFechar.Location = new Point(624, 256);
            buttonFechar.Margin = new Padding(2);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(68, 32);
            buttonFechar.TabIndex = 8;
            buttonFechar.Text = "Fechar";
            buttonFechar.UseVisualStyleBackColor = true;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // dataGridViewPrincipal
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPrincipal.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrincipal.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNome, colDataNascimento, colSexo, colLimiteCompra });
            dataGridViewPrincipal.Location = new Point(8, 38);
            dataGridViewPrincipal.Margin = new Padding(2);
            dataGridViewPrincipal.MultiSelect = false;
            dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            dataGridViewPrincipal.RowHeadersWidth = 62;
            dataGridViewPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrincipal.Size = new Size(683, 212);
            dataGridViewPrincipal.TabIndex = 3;
            // 
            // colCodigo
            // 
            colCodigo.DataPropertyName = "idCliente";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.Format = "###0";
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            colCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 8;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 150;
            // 
            // colNome
            // 
            colNome.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colNome.DefaultCellStyle = dataGridViewCellStyle3;
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 8;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.Width = 300;
            // 
            // colDataNascimento
            // 
            colDataNascimento.DataPropertyName = "DataNascimento";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            colDataNascimento.DefaultCellStyle = dataGridViewCellStyle4;
            colDataNascimento.HeaderText = "Nascimento";
            colDataNascimento.MinimumWidth = 8;
            colDataNascimento.Name = "colDataNascimento";
            colDataNascimento.ReadOnly = true;
            colDataNascimento.Width = 120;
            // 
            // colSexo
            // 
            colSexo.DataPropertyName = "Sexo";
            colSexo.HeaderText = "Sexo";
            colSexo.MinimumWidth = 8;
            colSexo.Name = "colSexo";
            colSexo.ReadOnly = true;
            colSexo.Width = 80;
            // 
            // colLimiteCompra
            // 
            colLimiteCompra.DataPropertyName = "LimiteCompra";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0.00";
            colLimiteCompra.DefaultCellStyle = dataGridViewCellStyle5;
            colLimiteCompra.HeaderText = "Limite de Compra";
            colLimiteCompra.MinimumWidth = 8;
            colLimiteCompra.Name = "colLimiteCompra";
            colLimiteCompra.ReadOnly = true;
            colLimiteCompra.Width = 200;
            // 
            // FrmClienteSelecionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 306);
            Controls.Add(dataGridViewPrincipal);
            Controls.Add(buttonFechar);
            Controls.Add(buttonConsultar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonInserir);
            Controls.Add(buttonPesquisar);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClienteSelecionar";
            RightToLeftLayout = true;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Cliente";
            Load += FrmClienteSelecionar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonPesquisar;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonExcluir;
        private Button buttonConsultar;
        private Button buttonFechar;
        private DataGridView dataGridViewPrincipal;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colDataNascimento;
        private DataGridViewCheckBoxColumn colSexo;
        private DataGridViewTextBoxColumn colLimiteCompra;
    }
}