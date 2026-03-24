namespace Apresentacao
{
    partial class FrmMenu
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
            barraStatusPrincipal = new StatusStrip();
            labelVersao = new ToolStripStatusLabel();
            menuPrincipal = new MenuStrip();
            menuCadastro = new ToolStripMenuItem();
            menuCliente = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            barraStatusPrincipal.SuspendLayout();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // barraStatusPrincipal
            // 
            barraStatusPrincipal.ImageScalingSize = new Size(24, 24);
            barraStatusPrincipal.Items.AddRange(new ToolStripItem[] { labelVersao });
            barraStatusPrincipal.Location = new Point(0, 312);
            barraStatusPrincipal.Name = "barraStatusPrincipal";
            barraStatusPrincipal.Size = new Size(778, 32);
            barraStatusPrincipal.TabIndex = 1;
            barraStatusPrincipal.Text = "statusStrip1";
            // 
            // labelVersao
            // 
            labelVersao.Name = "labelVersao";
            labelVersao.Size = new Size(94, 25);
            labelVersao.Text = "Versão 1.0";
            // 
            // menuPrincipal
            // 
            menuPrincipal.ImageScalingSize = new Size(24, 24);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { menuCadastro, menuSair });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(778, 33);
            menuPrincipal.TabIndex = 3;
            menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            menuCadastro.DropDownItems.AddRange(new ToolStripItem[] { menuCliente });
            menuCadastro.Name = "menuCadastro";
            menuCadastro.Size = new Size(99, 29);
            menuCadastro.Text = "&Cadastro";
            // 
            // menuCliente
            // 
            menuCliente.Name = "menuCliente";
            menuCliente.Size = new Size(270, 34);
            menuCliente.Text = "Cliente";
            menuCliente.Click += menuCadastro_Click;
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(57, 29);
            menuSair.Text = "&Sair";
            menuSair.Click += menuSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 344);
            Controls.Add(barraStatusPrincipal);
            Controls.Add(menuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Name = "FrmMenu";
            Text = "1ª Temporada";
            WindowState = FormWindowState.Maximized;
            barraStatusPrincipal.ResumeLayout(false);
            barraStatusPrincipal.PerformLayout();
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip barraStatusPrincipal;
        private ToolStripStatusLabel labelVersao;
        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuCadastro;
        private ToolStripMenuItem menuCliente;
        private ToolStripMenuItem menuSair;
    }
}