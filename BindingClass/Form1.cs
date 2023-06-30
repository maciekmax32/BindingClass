using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace BindingClass
{
    public partial class Form1 : Form
    {

        private ObservableCollection<FilmAlbum> filmAlbums;
        private BindingSource filmAlbumsBindingSource;

        public Form1()
        {
            InitializeComponent();
            filmAlbums = new ObservableCollection<FilmAlbum>();
            filmAlbumsBindingSource = new BindingSource();
            filmAlbumsBindingSource.DataSource = filmAlbums;

            dataGridView1.DataSource = filmAlbumsBindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataError += dataGridView1_DataError;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newFilmAlbum = new FilmAlbum
            {
                Tytul = string.Empty,
                RezyserAutor = string.Empty,
                WydawcaStudio = string.Empty,
                Dlugosc = TimeSpan.Zero,
                DataWydania = DateTime.Now,
                //Nosnik = Nosnik.VHS //
            };

            filmAlbums.Add(newFilmAlbum);
            filmAlbumsBindingSource.ResetBindings(false);
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedFilmAlbum = (FilmAlbum)dataGridView1.CurrentRow.DataBoundItem;
                var editForm = new EditForm(selectedFilmAlbum);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Proszê wybraæ wiersz do edycji.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                var selectedFilmAlbum = (FilmAlbum)dataGridView1.CurrentRow.DataBoundItem;
                filmAlbums.Remove(selectedFilmAlbum);
                filmAlbumsBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Proszê wybraæ wiersz do usuniêcia.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var serializer = new XmlSerializer(typeof(List<FilmAlbum>));
                using (var stream = File.OpenRead(openFileDialog.FileName))
                {
                    var importedFilmAlbums = (List<FilmAlbum>)serializer.Deserialize(stream);
                    filmAlbums.Clear();
                    foreach (var filmAlbum in importedFilmAlbums)
                    {
                        filmAlbums.Add(filmAlbum);
                    }
                }
            }
            filmAlbumsBindingSource.ResetBindings(false);
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ignoruj b³¹d walidacji danych 
            e.ThrowException = false;
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var serializer = new XmlSerializer(typeof(List<FilmAlbum>));
                using (var stream = File.Create(saveFileDialog.FileName))
                {
                    serializer.Serialize(stream, filmAlbums.ToList());
                }
            }
        }
    }
}