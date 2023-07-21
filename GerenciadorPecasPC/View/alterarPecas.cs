using GerenciadorPecasPC.Controller;
using GerenciadorPecasPC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorPecasPC.View
{
    public partial class alterarPecas : Form
    {
        public alterarPecas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxBuscarCodigo.Text);

            ManipulaPecas maPecas = new ManipulaPecas();
            maPecas.BuscaPecasCod();

            textBoxCodigo.Text = Pecas.Codigo.ToString();
            textBoxPecas.Text = Pecas.Peca;
            textBoxMarca.Text = Pecas.Marca;
            textBoxCapacidade.Text = Pecas.Capacidade;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            Pecas.Peca = textBoxPecas.Text;
            Pecas.Marca = textBoxMarca.Text;
            Pecas.Capacidade = textBoxCapacidade.Text;

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.AlterarPecas();

        }
    }
}
