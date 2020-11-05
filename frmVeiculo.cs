using Exercicio_veiculo.Classes;
using Exercicio_veiculo.DAO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Exercicio_veiculo
{
    public partial class frmVeiculo : Form
    {
        SqlDataReader dr;


        public frmVeiculo()
        {
            InitializeComponent();
        }
        private Veiculo MontaCadastro()
        {
            string[] s = cbxFab.Text.Split('-');

            Veiculo veiculo = new Veiculo
            {
                id            = Int32.Parse(txtCodigo.Text),
                modelo        = txtModelo.Text,
                ano           = Int32.Parse(txtAno.Text),
                ID_fabricante = cbxFab.Text,//new FabricanteDAO().ConsultaFabricante(txtCodigo.Text),
                preco         = float.Parse(mkdPreco.Text)
            };

            return veiculo;
        }
        private void ApagaCampos()
        {
            txtCodigo.Text = "";
            txtModelo.Text = "";
            txtAno.Text    = "";
            mkdPreco.Text  = "";
            cbxFab.Text    = "";
        }


        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            cbxFab.Items.Add(dr["id"].ToString() + dr["dsFabricante"].ToString());
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            string resp = new VeiculoDAO().GravarVeiculo(MontaCadastro());
            MessageBox.Show(resp);
            ApagaCampos();

        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new VeiculoDAO().ConsultaVeiculo(txtCodigo.Text);
            if (veiculo == null)
            {
                MessageBox.Show("Veículo Não existe. ");
            }
            else
            {
                txtCodigo.Text = veiculo.id.ToString();
                txtModelo.Text = veiculo.modelo.ToString();
                txtAno.Text    = veiculo.ano.ToString();
                mkdPreco.Text  = veiculo.preco.ToString();
                cbxFab.Text    = veiculo.ID_fabricante.ToString();

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            String resp = new VeiculoDAO().AlteraVeiculo(MontaCadastro());
            MessageBox.Show(resp);

            ApagaCampos();
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            string resp = new VeiculoDAO().ExcluirVeiculo(txtCodigo.Text);
            MessageBox.Show(resp);

            ApagaCampos();
        }
    }
}