namespace sp2
{
    class Clientes
    {
        //construção da classe
        public string nome {get; set;}
        public string endereco {get; set;}
        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}
        
       // construção do método

       public virtual void Pagar_Imposto(float v)
       {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100; //recebe o valor, tranfere para o atributo
            this.total = this.valor + this.valor_imposto;
       } 

    }
}