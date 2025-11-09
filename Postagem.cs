using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LacciAPI
{
    public class Postagem
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Data { get; set; }
        public int Conteudo { get; set; }
    }
}