using Exercicio_veiculo.Classes;
using Exercicio_veiculo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercicio_veiculo
{
    public partial class frmFabricante : Form
    {
        public frmFabricante()
        {
            InitializeComponent();
        }
        private Fabricante MontaCadastro()
        {
            Fabricante fabrica = new Fabricante
            {
                id = txtCod.Text,
                descricao = txtFab.Text
            };

            return fabrica;
        }
        private void ApagaCampos()
        {
            txtCod.Text = "";
            txtFab.Text = "";
        }
        private void btnIns_Click(object sender, EventArgs e)
        {
            /***
             * string resp = new FabricanteDAO().GravarFabricante(MontaCadastro());
            MessageBox.Show(resp);
            ApagaCampos();
            ***/
            Fabricante fabrica = MontaCadastro();
            String msg = new FabricanteDAO().GravarFabricante(fabrica);

            MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmFabricante_Load(object sender, EventArgs e)
        {

        }

        private void btnIns_Click_1(object sender, EventArgs e)
        {
            Fabricante fabrica = MontaCadastro();
            String msg = new FabricanteDAO().GravarFabricante(fabrica);

            MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ApagaCampos();
        }

        private void btnCon_Click_1(object sender, EventArgs e)
        {
            Fabricante fabrica = new FabricanteDAO().ConsultaFabricante(txtCod.Text);
            if (fabrica == null)
            {
                MessageBox.Show("Fabricante Não existe ");
            }
            else
            {
                txtCod.Text = fabrica.id;
                txtFab.Text = fabrica.descricao;

            }
        }

        private void btnAlt_Click_1(object sender, EventArgs e)
        {
            String resp = new FabricanteDAO().AlteraFabricante(MontaCadastro());
            MessageBox.Show(resp);

            ApagaCampos();
        }

        private void btnExc_Click_1(object sender, EventArgs e)
        {
            string resp = new FabricanteDAO().ExcluirFabricante(txtCod.Text);
            MessageBox.Show(resp);

            ApagaCampos();
        }
    }
}
