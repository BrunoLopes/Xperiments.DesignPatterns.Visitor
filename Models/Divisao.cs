namespace Xperiments.DesignPatterns.Visitor.Models
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; private set;}
        public IExpressao Direita { get; private set;}

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda / valorDireita;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeDivisao(this);
        }
    }
}