namespace RemoverRepetidos
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Cliente(string nome, string cpf) 
        { 
            Nome = nome;
            Cpf = cpf;
        }

        public override bool Equals(object obj)
        {
            if (Cpf == ((Cliente) obj).Cpf)
                return true;

            return false;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " cpf: " + Cpf;
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }
}
