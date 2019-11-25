using System;
using System.Collections.Generic;
using ClienteApi.Lib.Repository;
using ClienteApi.Lib.Models;

namespace ClienteApi.Lib.Business
{
    public class LocalizacaoBusiness
    {
        private LocalizacaoRepository _repository { get; set; } = new LocalizacaoRepository();
        public List<Localizacao> GetLocalizacoes() => _repository.GetLocations();
    }
}