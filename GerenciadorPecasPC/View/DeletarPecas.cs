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
    public partial class DeletarPecas : Form
    {
        public DeletarPecas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.DeletarPecas();

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

        
    }
}
