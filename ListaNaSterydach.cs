using System.Collections;

public class ListaNaSterydach<T> : List<T>
{
    public override string ToString()
    {
        string wynik = "";
        IEnumerator enumerator = this.GetEnumerator();
        while (enumerator.MoveNext())
        {
            object element = enumerator.Current;
            if (element != null)
            {
                wynik += element.ToString() + "\n";
            }
        }return wynik;  
    }
}