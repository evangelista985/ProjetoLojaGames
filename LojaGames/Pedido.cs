using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LojaGames
{
    public partial class Pedido : Form
    {

        //instanciando a classe conexão
        conexao con = new conexao();
        public Pedido()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbTiposJogos.Items.Add("Jogo1");
            cmbTiposJogos.Items.Add("Jogo2");
            cmbTiposJogos.Items.Add("Jogo3");

            decimal valorProduto = 1250.75m;
            decimal valorFrete = 35.00m;
            decimal total = valorProduto + valorFrete;

            
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando variável
            double valorJogo = 0;
            double valorOpcionais = 0;
            double valorPagar = 0;

            if (cmbTiposJogos.SelectedIndex == 0)
            {
                valorJogo = 20;
            }
            else if (cmbTiposJogos.SelectedIndex == 1)
            {
                valorJogo = 30;
            }
            else if (cmbTiposJogos.SelectedIndex == 2)
            {
                valorJogo = 50;
            }
            if (chk2Contas.Checked == true)
            {
                valorOpcionais = valorOpcionais + 5;
            }
            if (chk2Controles.Checked == true)
            {
                valorOpcionais = valorOpcionais + 6;
            }
            if (chkTotalPass.Checked == true)
            {
                valorOpcionais = valorOpcionais + 3;
            }
            if (chkTesteDrive.Checked == true)
            {
                valorOpcionais = valorOpcionais + 4;
            }
            else
            {

            }
            valorPagar = valorJogo + valorOpcionais;
            txtValorJogo.Text = Convert.ToString(valorJogo);
            txtValorOpcionais.Text = Convert.ToString(valorOpcionais);
            txtValorPagar.Text = Convert.ToString(valorPagar);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //vefifica os campos
            if (txtValorJogo.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorJogo.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tipoJogo,valorJogo,valorOpcionais,valorPagar) values(@tjogos,@vjogo,@vopcionais,@vpagar)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@tjogos", MySqlDbType.Text).Value = cmbTiposJogos.Text;
                    cmd.Parameters.Add("@vjogo", MySqlDbType.Text).Value = txtValorJogo.Text;
                    cmd.Parameters.Add("@vopcionais", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@vpagar", MySqlDbType.Text).Value = txtValorPagar.Text;
                    //executa a ação
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTiposJogos.Text = "";
                    txtValorJogo.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorPagar.Text = "";
                    cmbTiposJogos.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void dgvPedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedidos();
        }
        //Método que vai carregar informações do datagrid
        public void CarregarPedidos()
        {
            try
            {
                txtCodigo.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString();
                cmbTiposJogos.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();
                txtValorJogo.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();
                txtValorOpcionais.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();
                txtValorPagar.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erros ao clicar" + error);
            }

        }

       

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPedido.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {

                dgvPedido.DataSource = null;
            }
        }

        private void Pedido_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40); // altera cor de fundo da tela ao iniciar (RGB)
        }

        private void chk2Contas_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2Contas.Checked)
            {
                chk2Contas.BackColor = Color.LightBlue;  // Fundo azul claro
                chk2Contas.ForeColor = Color.DarkBlue;   // Texto azul escuro
            }
            else
            {
                chk2Contas.BackColor = SystemColors.Control; // Cor padrão
                chk2Contas.ForeColor = Color.Black;          // Texto preto
            }
        }

        private void chk2Controles_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2Controles.Checked)
            {
                chk2Controles.BackColor = Color.LightBlue;  // Fundo azul claro
                chk2Controles.ForeColor = Color.DarkBlue;   // Texto azul escuro
            }
            else
            {
                chk2Controles.BackColor = SystemColors.Control; // Cor padrão
                chk2Controles.ForeColor = Color.Black;          // Texto preto
            }

        }

        private void chkTotalPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTotalPass.Checked)
            {
                chkTotalPass.BackColor = Color.LightBlue;  // Fundo azul claro
                chkTotalPass.ForeColor = Color.DarkBlue;   // Texto azul escuro
            }
            else
            {
                chkTotalPass.BackColor = SystemColors.Control; // Cor padrão
                chkTotalPass.ForeColor = Color.Black;          // Texto preto
            }
        }

        private void chkTesteDrive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTesteDrive.Checked)
            {
                chkTesteDrive.BackColor = Color.LightBlue;  // Fundo azul claro
                chkTesteDrive.ForeColor = Color.DarkBlue;   // Texto azul escuro
            }
            else
            {
                chkTesteDrive.BackColor = SystemColors.Control; // Cor padrão
                chkTesteDrive.ForeColor = Color.Black;          // Texto preto
            }
        }
    }
}       

      


        
    

