using System.Collections;

public class Osoby
{
    private ListaNaSterydach<Osoba> listaOsob = new ListaNaSterydach<Osoba>();

    public Osoby(ListaNaSterydach<Osoba> lista)
    {
        this.listaOsob = lista;
    }

    public IEnumerator GetEnumerator()
    {
        return new OsobyEnumerator(listaOsob);
    }
    public class OsobyEnumerator : IEnumerator
    {
        private List<Osoba> listaOsob = new List<Osoba>();
        private int currentIndex = -1;
        public OsobyEnumerator(List<Osoba> listaOsob)
        {
            this.listaOsob = listaOsob;
        }
        public object Current
        {
            get { return listaOsob[currentIndex]; }
        }
        public bool MoveNext()
        {
            this.currentIndex += 2;
            if (this.currentIndex < listaOsob.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            this.currentIndex = -2;
        }
    }
}