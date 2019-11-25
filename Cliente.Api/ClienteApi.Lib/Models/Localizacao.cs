namespace ClienteApi.Lib.Models
{
    public class Localizacao
    {
        public Localizacao(string Pais, string Capital, string Continente)
        {
            this.Pais = Pais;
            this.Capital = Capital;
            this.Continente = Continente;
        }
        
        public string Pais { get; set; }
        public string Capital { get; set; }
        public string Continente { get; set; }
    }
}