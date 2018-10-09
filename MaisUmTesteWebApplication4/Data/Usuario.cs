using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaisUmTesteWebApplication4.Data
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string ComfirmacaoSenha { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public String  DataNascimento { get; set; }
    }
}
