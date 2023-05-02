namespace Classes;
public class Vestuario : Gastos
{

    public Vestuario(string nome, decimal valorInicial) : base(nome, valorInicial)
    {
    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margem = (ValorAcumulado * 0.02m);
        EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Vestuario");
    }
}