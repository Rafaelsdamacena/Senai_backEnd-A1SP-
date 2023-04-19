using System;
namespace sp2
{
    class Program
    {
       static void Main(string[] args)
       {
            float val_pag;
            Console.WriteLine("Informe seu nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informe seu endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)");
            string var_tipo = Console.ReadLine();
            //condicional para instanciar se for pf ou pj
            if (var_tipo == "f")
            {
                //condicional para Pessoa Física 
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informe o seu CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe o seu RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine()); //
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine(" Pessoa Física ");
                Console.WriteLine(" Nome : " + pf.nome);
                Console.WriteLine(" Endereço : " + pf.endereco);
                Console.WriteLine(" CPF : " + pf.cpf);
                Console.WriteLine(" RG : " + pf.rg);
                Console.WriteLine(" Valor de Compra:" + pf.valor.ToString("C")); //formatar o valor para moeda
                Console.WriteLine(" Imposto : " + pf.valor_imposto.ToString("C"));
                Console.WriteLine(" Total a pagar : " + pf.total.ToString("C"));              
            }
            if(var_tipo == "j")
            //Condicional para pessoa jurídica
            {
                Pessoa_juridica pj = new Pessoa_juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine(" Pessoa Jurídica ");
                Console.WriteLine(" Nome : " + pj.nome);
                Console.WriteLine(" Endereço : " + pj.endereco);
                Console.WriteLine(" CPF : " + pj.cnpj);
                Console.WriteLine(" RG : " + pj.ie);
                Console.WriteLine(" Valor de Compra:" + pj.valor.ToString("C")); 
                Console.WriteLine(" Imposto : " + pj.valor_imposto.ToString("C"));
                Console.WriteLine(" Total a pagar : " + pj.total.ToString("C"));

            }
       }

    }
}
