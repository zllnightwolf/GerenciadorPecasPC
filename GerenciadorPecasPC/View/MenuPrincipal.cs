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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarPecas telaCadastrar = new TelaCadastrarPecas();
            telaCadastrar.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarPecas pesquisar = new PesquisarPecas();
            pesquisar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterarPecas alterar = new alterarPecas();
            alterar.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarPecas deletar = new DeletarPecas();
            deletar.Show();
        }
    }
}
