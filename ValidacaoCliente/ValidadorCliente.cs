using System;
using System.Collections.Generic;
using System.Globalization;

namespace ValidacaoCliente
{
    public static class ValidadorCliente
    {
        public static Dictionary<string, string> ValidarCliente(ClienteDto cliente)
        {
            var erros = new Dictionary<string, string>();

            if (ValidarNome(cliente.nome) != null)
                erros.Append(ValidarNome(cliente.nome));

            if (ValidarCpf(cliente.cpf) != null)
                erros.Append(ValidarCpf(cliente.cpf));

            if (ValidarIdade(cliente.dt_nascimento) != null)
                erros.Append(ValidarIdade(cliente.dt_nascimento));

            if (ValidarEstadoCivil(cliente.estado_civil) != null)
                erros.Append(ValidarEstadoCivil(cliente.estado_civil));

            if (ValidarRendaMensal(cliente.renda_mensal) != null)
                erros.Append(ValidarRendaMensal(cliente.renda_mensal));

            if (ValidarDependentes(cliente.dependentes) != null)
                erros.Append(ValidarDependentes(cliente.dependentes));

            return erros;
        }

        private static Dictionary<string, string> ValidarNome(string nome)
        {
            var erro = new Dictionary<string, string>();

            if (nome.Length < 5)
                erro.Add("nome", "Nome deve ter pelo menos 5 caracteres");

            if (erro.Count > 0)
                return erro;

            return null;
        }

        private static Dictionary<string, string> ValidarCpf(string cpf)
        {
            var erro = new Dictionary<string, string>();

            if (!cpf.CpfValido())
                erro.Add("cpf", "CPF invalido");

            if (erro.Count > 0)
                return erro;

            return null;
        }

        private static Dictionary<string, string> ValidarIdade(string dataNascimento) 
        {
            var erro = new Dictionary<string, string>();
            var dataConvertida = Convert.ToDateTime(String.Format("{0:dd/MM/yyyy}", dataNascimento));

            var idade = DateTime.Now.Year - dataConvertida.Year;

            if (DateTime.Now.DayOfYear < dataConvertida.DayOfYear)
                idade--;
            
            if (idade <= 18)
                erro.Add("dt_nascimento", "Data de nascimento invalida");

            if (erro.Count > 0)
                return erro;

            return null;
        }

        private static Dictionary<string, string> ValidarRendaMensal(string rendaMensal)
        {
            float renda = float.Parse(rendaMensal, CultureInfo.InvariantCulture.NumberFormat);

            var erro = new Dictionary<string, string>();

            if (renda < 0)
                erro.Add("renda_mensal", "Renda mensal invalida");

            if (erro.Count > 0)
                return erro;

            return null;
        }

        private static Dictionary<string, string> ValidarEstadoCivil(string estadoCivil)
        {
            var erro = new Dictionary<string, string>();

            var caracter = estadoCivil.ToString().ToUpper();

            if (caracter != "C" && caracter != "S" && caracter != "V" && caracter != "D")
                erro.Add("estado_civil", "Estado civil invalido");

            if (erro.Count > 0)
                return erro;

            return null;
        }

        private static Dictionary<string, string> ValidarDependentes(string dependentes)
        {
            int quantidadeDependentes = int.Parse(dependentes);

            var erro = new Dictionary<string, string>();

            if (quantidadeDependentes < 0 || quantidadeDependentes > 10)
                erro.Add("dependentes", "Numero de dependentes invalido");

            if (erro.Count > 0)
                return erro;

            return null;
        }
    }
}
