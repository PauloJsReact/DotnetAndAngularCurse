using System;
using System.Collections.Generic;
using Proeventos.Domain;

namespace ProEventos.Domain
{
    public class Evento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemUrl { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedesSocials { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }

    }
}