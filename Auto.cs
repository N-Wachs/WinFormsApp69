// Agregation

namespace WinFormsApp69;

/// <summary>
/// Eine Beispiel Objektklasse, die ein Auto repräsentiert. 
/// Sie enthält eine Liste von Reifen und einen optionalen Spoiler als Anbau.
/// </summary>
public class Auto
{
    #region Felder
    // Unsere Felder sind private, damit sie nicht direkt von außen zugänglich sind.
    private List<Reifen> _räder;
    private Spoiler? _anbau;
    #endregion

    #region Accessoren/Modifier
    // Accessoren und Modifier (Getter und Setter) ermöglichen den Zugriff auf die privaten Felder von außen, während sie gleichzeitig die Kapselung wahren.
    private List<Reifen> Räder { get => _räder; set => _räder = value; }
    private Spoiler? Anbau { get => _anbau; set => _anbau = value; }
    #endregion

    #region Konstruktoren
    // Standartkonstruktor
    public Auto()
    {
        _räder = new List<Reifen>();
        _anbau = null;
    }

    // Spezialkonstruktor
    public Auto(List<Reifen> räder, Spoiler anbau)
    {
        _räder = räder;
        _anbau = anbau;
    }
    #endregion

    #region Worker
    // Agregationsmethoden für die Reifen und den Anbau, um die Verwaltung der Komponenten zu erleichtern. MUSS!!!!
    public void AddReifen(Reifen reifen)
    {
        Räder.Add(reifen);
    }
    public Reifen? RemoveReifen(Reifen reifen)
    {
        // "r => r == reifen" ist eine Lambda-Ausdruck, der eine anonyme Funktion definiert, die ein Reifen-Objekt (r) als Eingabe nimmt und überprüft,
        // ob es gleich dem übergebenen Reifen-Objekt (reifen) ist.
        Reifen temp = Räder.Find(r => r == reifen);
        Räder.Remove(temp);
        return temp;
    }

    public void SetAnbau(Spoiler anbau)
    {
        Anbau = anbau;
    }
    public Spoiler? RemoveAnbau()
    {
        Spoiler temp = Anbau;
        Anbau = null;
        return temp;
    }
    #endregion
}



// Klassen damit nicht Rot unterstrichen...
public class Spoiler
{
}

public class Reifen
{
}