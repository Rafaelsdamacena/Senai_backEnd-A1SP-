namespace sp2
{
    class Pessoa_Fisica : Clientes // clientes é a classe mãe e precisa ser mencionada para herdar os atributos
    {
        public string cpf {get; set;}
        public string rg {get; set;}
    }
}