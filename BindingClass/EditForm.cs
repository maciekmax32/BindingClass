using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingClass;

namespace BindingClass
{
    public partial class EditForm : Form

    {

        private FilmAlbum filmAlbum;
        public EditForm(FilmAlbum filmAlbum)
        {
            InitializeComponent();

            this.filmAlbum = filmAlbum;
            txtTytul.Text = filmAlbum.tytul;
            txtRezyserAutor.Text = filmAlbum.rezyserAutor;
            txtWydawcaStudio.Text = filmAlbum.wydawcaStudio;
            //txtNosnik.Text = filmAlbum.Nosnik.ToString();
            txtDlugosc.Text = filmAlbum.DlugoscString;
            dtpDataWydania.Value = filmAlbum.dataWydania;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmAlbum.Tytul = txtTytul.Text;
            filmAlbum.rezyserAutor = txtRezyserAutor.Text;
            filmAlbum.wydawcaStudio = txtWydawcaStudio.Text;
            //filmAlbum.nosnik = (Nosnik)Enum.Parse(typeof(Nosnik), txtNosnik.Text);
            filmAlbum.dataWydania = dtpDataWydania.Value;
            Close();

        }
    }
}
