using System.ComponentModel;
using BindingClass;
public class FilmAlbum : INotifyPropertyChanged
{
    public string tytul;
    public string rezyserAutor;
    public string wydawcaStudio;
    public TimeSpan dlugosc;
    public DateTime dataWydania;
    //public Nosnik nosnik;

    [DisplayName("Tytuł")]
    public string Tytul
    {
        get { return tytul; }
        set
        {
            if (tytul != value)
            {
                tytul = value;
                OnPropertyChanged(nameof(Tytul));
            }
        }
    }
    [DisplayName("Reżyser/Autor")]
    public string RezyserAutor
    {
        get { return rezyserAutor; }
        set
        {
            if (rezyserAutor != value)
            {
                rezyserAutor = value;
                OnPropertyChanged(nameof(RezyserAutor));
            }
        }
    }
    [DisplayName("Wydawca/Studio")]
    public string WydawcaStudio
    {
        get { return wydawcaStudio; }
        set
        {
            if (wydawcaStudio != value)
            {
                wydawcaStudio = value;
                OnPropertyChanged(nameof(WydawcaStudio));
            }
        }
    }
    [DisplayName("Długość trwania")]
    public TimeSpan Dlugosc
    {
        get { return dlugosc; }
        set
        {
            if (dlugosc != value)
            {
                dlugosc = value;
                OnPropertyChanged(nameof(Dlugosc));
                OnPropertyChanged(nameof(DlugoscString));
            }
        }
    }
    [Browsable(false)]
    public string DlugoscString
    {
        get { return Dlugosc.ToString(@"hh\:mm\:ss"); }
        set
        {
            TimeSpan parsedDlugosc;
            if (TimeSpan.TryParse(value, out parsedDlugosc))
            {
                Dlugosc = parsedDlugosc;
            }
            else
            {
               
            }
        }
    }
    [DisplayName("Data wydania")]
    public DateTime DataWydania
    {
        get { return dataWydania; }
        set
        {
            if (dataWydania != value)
            {
                dataWydania = value;
                OnPropertyChanged(nameof(DataWydania));
            }
        }
    }

    //public Nosnik Nosnik
    //{
    //    get { return nosnik; }
    //    set
    //    {
    //        if (nosnik != value)
    //        {
    //            nosnik = value;
    //            OnPropertyChanged(nameof(Nosnik));
    //        }
    //    }
    //}

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
