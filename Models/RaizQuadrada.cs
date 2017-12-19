using System;

namespace Xperiments.DesignPatterns.Visitor.Models
{
    public class RaizQuadrada : IExpressao 
    {
        public IExpressao Expressao { get; private set;}

        public RaizQuadrada(IExpressao e) 
        {
            this.Expressao = e;
        }

        public int Avalia() 
        {
            return (int) Math.Sqrt(Expressao.Avalia());
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeRaizQuadrada(this);
        }
    }
}