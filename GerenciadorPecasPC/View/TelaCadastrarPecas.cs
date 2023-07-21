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
    public partial class TelaCadastrarPecas : Form
    {
        public TelaCadastrarPecas()
        {
            InitializeComponent();
        }

        private void btnCadastrarPecas_Click(object sender, EventArgs e)
        {
            Pecas.Peca = textBoxPecas.Text;
            Pecas.Marca = textBoxMarcas.Text;
            Pecas.Capacidade = textBoxCapacidades.Text;

            ManipulaPecas mPecas = new ManipulaPecas();
            mPecas.CadPecas();
        }

        public void AbrirCadastro()
        {
            this.ShowDialog();
        }
    }
}
