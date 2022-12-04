using System;

namespace ValidacaoCliente
{
    public class ClienteDto
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string dt_nascimento { get; set; }
        public string renda_mensal { get; set; }
        public string estado_civil { get; set; }
        public string dependentes { get; set; }
    }
}
