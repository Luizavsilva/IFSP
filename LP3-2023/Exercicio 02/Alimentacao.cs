namespace Classes;
public class Alimentacao : Gastos
{

    public Alimentacao(string nome, decimal valorInicial) : base(nome, valorInicial)
    {
    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margem = (ValorAcumulado * 0.01m);
        EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Alimentacao");
    }
}