namespace ClienteApi.Lib.Models
{
    public class Cliente
    {
        public Cliente(int Id, string Nome, string Documento, string Cidade,
        string Endereco, string Complemento, string Pais)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Documento = Documento;
            this.Cidade = Cidade;
            this.Endereco = Endereco;
            this.Complemento = Complemento;
            this.Pais = Pais;
        }
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Pais { get; set; }
    }
}