namespace Xperiments.DesignPatterns.Visitor.Models
{
    public interface IExpressao
    {
        
        int Avalia();

        void Aceita(Impressora impressora);
    }
}