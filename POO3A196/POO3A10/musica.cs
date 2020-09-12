using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO3A10.BLL;
using POO3A10.DAL;
using POO3A10.DTO;

namespace POO3A196
{
    public partial class musica : Form
    {

        tblMusicaBLL bllMusica = new tblMusicaBLL();
        tblMusicaDTO dtoMusica = new tblMusicaDTO();

        public musica()
        {
            InitializeComponent();
        }

        private void musica_Load(object sender, EventArgs e)
        {
            GridMusica.DataSource = bllMusica.PesquisarMusicas();
            this.PreencheMusica();
        }

        private void btnPesquisarMusicas_Click(object sender, EventArgs e)
        {
            string condicao = "nomeProduto like '%" + txtPesquisarMusicas.Text + "%' or descricao like '%" + txtPesquisarMusicas.Text + "%'";
            GridMusica.DataSource = bllMusica.PesquisarMusicas(condicao);
        }

        private void Musica_Load(object sender, EventArgs e)
        {

        }


        public void PreencheMusica()
        {
            comboMusica.DataSource = bllMusica.PesquisarMusicas();
            comboMusica.DisplayMember = "descricao";
            comboMusica.ValueMember = "idMusica";
        }
    }
}
