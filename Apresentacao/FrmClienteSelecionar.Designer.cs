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
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonPesquisar = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            buttonExcluir = new Button();
            buttonConsultar = new Button();
            buttonFechar = new Button();
            dataGridViewPrincipal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).BeginInit();
            SuspendLayout();
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(12, 18);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(86, 25);
            labelPesquisa.TabIndex = 0;
            labelPesquisa.Text = "ID/Nome";
            labelPesquisa.Click += label1_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(104, 15);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(671, 31);
            textBoxPesquisa.TabIndex = 1;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(786, 13);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(112, 34);
            buttonPesquisar.TabIndex = 2;
            buttonPesquisar.Text = "&Buscar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(349, 407);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(97, 40);
            buttonInserir.TabIndex = 4;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(462, 407);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(97, 40);
            buttonAlterar.TabIndex = 5;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(575, 407);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(97, 40);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(688, 407);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(97, 40);
            buttonConsultar.TabIndex = 7;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            buttonFechar.Location = new Point(801, 407);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(97, 40);
            buttonFechar.TabIndex = 8;
            buttonFechar.Text = "Fechar";
            buttonFechar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPrincipal
            // 
            dataGridViewPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrincipal.Location = new Point(12, 61);
            dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            dataGridViewPrincipal.RowHeadersWidth = 62;
            dataGridViewPrincipal.Size = new Size(886, 340);
            dataGridViewPrincipal.TabIndex = 3;
            // 
            // FrmClienteSelecionar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 459);
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
    }
}