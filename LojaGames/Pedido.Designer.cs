using System;

namespace LojaGames
{
    partial class Pedido
    {
       
        private System.ComponentModel.IContainer components = null;

        
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
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblValorJogo = new System.Windows.Forms.Label();
            this.cmbTiposJogos = new System.Windows.Forms.ComboBox();
            this.txtValorJogo = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chk2Contas = new System.Windows.Forms.CheckBox();
            this.chkTesteDrive = new System.Windows.Forms.CheckBox();
            this.chkTotalPass = new System.Windows.Forms.CheckBox();
            this.chk2Controles = new System.Windows.Forms.CheckBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOpcionais.ForeColor = System.Drawing.Color.Silver;
            this.lblValorOpcionais.Location = new System.Drawing.Point(451, 34);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(135, 13);
            this.lblValorOpcionais.TabIndex = 0;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagar.ForeColor = System.Drawing.Color.Silver;
            this.lblValorPagar.Location = new System.Drawing.Point(670, 34);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(97, 13);
            this.lblValorPagar.TabIndex = 1;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorJogo
            // 
            this.lblValorJogo.AutoSize = true;
            this.lblValorJogo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorJogo.ForeColor = System.Drawing.Color.Silver;
            this.lblValorJogo.Location = new System.Drawing.Point(236, 34);
            this.lblValorJogo.Name = "lblValorJogo";
            this.lblValorJogo.Size = new System.Drawing.Size(96, 13);
            this.lblValorJogo.TabIndex = 2;
            this.lblValorJogo.Text = "VALOR DO JOGO";
            // 
            // cmbTiposJogos
            // 
            this.cmbTiposJogos.BackColor = System.Drawing.Color.Silver;
            this.cmbTiposJogos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiposJogos.ForeColor = System.Drawing.Color.Black;
            this.cmbTiposJogos.FormattingEnabled = true;
            this.cmbTiposJogos.Location = new System.Drawing.Point(22, 63);
            this.cmbTiposJogos.Name = "cmbTiposJogos";
            this.cmbTiposJogos.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposJogos.TabIndex = 3;
            this.cmbTiposJogos.Text = "TIPOS DE JOGOS";
            // 
            // txtValorJogo
            // 
            this.txtValorJogo.Location = new System.Drawing.Point(239, 64);
            this.txtValorJogo.Name = "txtValorJogo";
            this.txtValorJogo.Size = new System.Drawing.Size(100, 20);
            this.txtValorJogo.TabIndex = 4;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(454, 64);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 5;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chk2Contas);
            this.grpOpcionais.Controls.Add(this.chkTesteDrive);
            this.grpOpcionais.Controls.Add(this.chkTotalPass);
            this.grpOpcionais.Controls.Add(this.chk2Controles);
            this.grpOpcionais.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpcionais.ForeColor = System.Drawing.Color.Silver;
            this.grpOpcionais.Location = new System.Drawing.Point(22, 112);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(213, 123);
            this.grpOpcionais.TabIndex = 6;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            // 
            // chk2Contas
            // 
            this.chk2Contas.AutoSize = true;
            this.chk2Contas.Location = new System.Drawing.Point(11, 19);
            this.chk2Contas.Name = "chk2Contas";
            this.chk2Contas.Size = new System.Drawing.Size(80, 17);
            this.chk2Contas.TabIndex = 10;
            this.chk2Contas.Text = "2 CONTAS";
            this.chk2Contas.UseVisualStyleBackColor = true;
            this.chk2Contas.CheckedChanged += new System.EventHandler(this.chk2Contas_CheckedChanged);
            // 
            // chkTesteDrive
            // 
            this.chkTesteDrive.AutoSize = true;
            this.chkTesteDrive.Location = new System.Drawing.Point(11, 88);
            this.chkTesteDrive.Name = "chkTesteDrive";
            this.chkTesteDrive.Size = new System.Drawing.Size(104, 17);
            this.chkTesteDrive.TabIndex = 8;
            this.chkTesteDrive.Text = "TESTE DRIVER";
            this.chkTesteDrive.UseVisualStyleBackColor = true;
            this.chkTesteDrive.CheckedChanged += new System.EventHandler(this.chkTesteDrive_CheckedChanged);
            // 
            // chkTotalPass
            // 
            this.chkTotalPass.AutoSize = true;
            this.chkTotalPass.Location = new System.Drawing.Point(11, 65);
            this.chkTotalPass.Name = "chkTotalPass";
            this.chkTotalPass.Size = new System.Drawing.Size(137, 17);
            this.chkTotalPass.TabIndex = 9;
            this.chkTotalPass.Text = "TOTAL PASS GAMER";
            this.chkTotalPass.UseVisualStyleBackColor = true;
            this.chkTotalPass.CheckedChanged += new System.EventHandler(this.chkTotalPass_CheckedChanged);
            // 
            // chk2Controles
            // 
            this.chk2Controles.AutoSize = true;
            this.chk2Controles.Location = new System.Drawing.Point(11, 42);
            this.chk2Controles.Name = "chk2Controles";
            this.chk2Controles.Size = new System.Drawing.Size(100, 17);
            this.chk2Controles.TabIndex = 7;
            this.chk2Controles.Text = "2 CONTROLES";
            this.chk2Controles.UseVisualStyleBackColor = true;
            this.chk2Controles.CheckedChanged += new System.EventHandler(this.chk2Controles_CheckedChanged);
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(673, 64);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 11;
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(22, 280);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(751, 85);
            this.dgvPedido.TabIndex = 12;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(22, 380);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 28);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(673, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 28);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(454, 380);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(239, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(22, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.ForeColor = System.Drawing.Color.Silver;
            this.lblPesquisar.Location = new System.Drawing.Point(268, 218);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(71, 13);
            this.lblPesquisar.TabIndex = 19;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(454, 215);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 20;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged_1);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorJogo);
            this.Controls.Add(this.cmbTiposJogos);
            this.Controls.Add(this.lblValorJogo);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblValorJogo;
        private System.Windows.Forms.ComboBox cmbTiposJogos;
        private System.Windows.Forms.TextBox txtValorJogo;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chk2Controles;
        private System.Windows.Forms.CheckBox chkTesteDrive;
        private System.Windows.Forms.CheckBox chkTotalPass;
        private System.Windows.Forms.CheckBox chk2Contas;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}