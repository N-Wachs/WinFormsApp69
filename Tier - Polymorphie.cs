// Polymorphie bsp. Tiere

namespace Polymorphie;

// Basisklasse für die verschiedenen Tiere. 'Abstract' für die Polymorphie.
public abstract class Tier
{
    // Felder die jedes Tier hat
    #region Felder
    private DateTime _geburtsDatum;
    private string _name;
    #endregion

    // Öffentlich Accessoren und Modifier für die Felder, damit sie von den Kind Klassen zugänglich sind
    #region Accessoren/Modifier
    public DateTime GeburtsDatum { get => _geburtsDatum; set => _geburtsDatum = value; }
    public string Name { get => _name; set => _name = value; }
    #endregion

    #region Konstruktoren
    public Tier()
    {
        _geburtsDatum = DateTime.Now;
        _name = "Unbekannt";
    }
    public Tier(DateTime geburtsDatum, string name)
    {
        _geburtsDatum = geburtsDatum;
        _name = name;
    }
    #endregion

    #region Worker
    // Funuktion für die alle Tiere können, damit sie von den Kind Klassen geerbt werden kann
    // 'Virtual' damit die Kind Klassen sie überschreiben können, aber nicht müssen
    public virtual void Laufen()
    {
        Console.WriteLine($"{Name} läuft.");
    }

    // Abstrakte-Funktion mit Polymorphie 2 grades die JEDE Kindklasse haben muss
    public abstract void MachtGeräusch();
    #endregion
}

// Eine Kind Klasse 'Katze' die von der Basisklasse 'Tier' erbt
public class Katze : Tier
{
    // Felder die nur die Katze hat
    #region Felder
    private bool _istSchnurrend;
    #endregion

    // Private Accessoren und Modifier für die Felder, damit sie nur von der Klasse selbst zugänglich sind
    #region Accessoren/Modifier
    private bool IstSchnurrend { get => _istSchnurrend; set => _istSchnurrend = value; }
    #endregion

    // Konstruktoren die den Konstruktor der Basisklasse aufrufen, damit die Felder der Basisklasse auch initialisiert werden
    #region Konstruktoren
    // Standart Konstruktor
    public Katze() : base()
    {
        _istSchnurrend = false;
    }

    // Spezialkonstruktor
    public Katze(DateTime geburtsDatum, string name, bool istSchnurrend) : base(geburtsDatum, name)
    {
        _istSchnurrend = istSchnurrend;
    }
    #endregion

    #region Worker
    // Die Abstrakte-Funktion der Basisklasse wird hier gesetzt
    public override void MachtGeräusch()
    {
        Console.WriteLine($"{base.Name} schnurrt.");
    }

    // Die Virtuelle-Funktion der Basisklasse wird hier überschrieben, damit die Katze leise schleicht, anstatt normal zu laufen
    // Somit hat die Katze eine eigene Implementierung der Funktion, die von der Basisklasse geerbt wurde, aber nicht die gleiche wie die anderen Tiere ist
    public override void Laufen()
    {
        Console.WriteLine($"{base.Name} schleicht leise.");
    }
    #endregion
}

// Weitere Kind Klasse 'Hund' die von der Basisklasse 'Tier' erbt
public class Hund : Tier
{
    #region Felder
    private bool _istHalil;
    #endregion

    #region Accessoren/Modifier
    private bool IstHalil { get => _istHalil; set => _istHalil = value; }
    #endregion

    #region Konstruktoren
    public Hund() : base()
    {
        _istHalil = true;
    }
    public Hund(DateTime geburtsDatum, string name, bool istHalil) : base(geburtsDatum, name)
    {
        _istHalil = istHalil;
    }
    #endregion

    #region Worker
    // Die Abstrakte-Funktion der Basisklasse wird hier gesetzt
    public override void MachtGeräusch()
    {
        Console.WriteLine($"{base.Name} bellt.");
    }
    #endregion
}