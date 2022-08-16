namespace LoginAzureActiveDirectoryB2CWebAPI.Model
{
    public class Cliente
    {
        public Cliente(string nome, string sobrenome, DateTime dataDeNascimento, string cPF)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataDeNascimento = dataDeNascimento;
            CPF = cPF;
        }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string CPF { get; set; }
    }
}