public enum SporcuCinsiyet
{
    kiz, erkek

}
public enum SporcuBrans
{
    basketboll, futbol, voleybol
}
public class Sporcu
{
    public SporcuCinsiyet cinsiyet { get; set; }
    public SporcuBrans brans { get; set; }
    public string ad { get; set; }
    public string soyad { get; set; }
    public double boy { get; set; }
    public double kilo { get; set; }
}
