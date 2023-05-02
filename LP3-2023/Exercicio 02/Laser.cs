namespace Classes;
public class Laser : Gastos
{

    private readonly decimal _bonusLaser = 50m;

    public Laser(string Cliente, decimal valorInicial, decimal bonuslaser = 50) : base(Cliente, valorInicial)
    => _bonusLaser = bonuslaser;

    public override void ExecutarTransacaoFimdeMes()
    {
    decimal margem = (ValorAcumulado * 0.03m);
    EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Laser");
    if (_bonusLaser != 0)
    {
        EfetuarTransacao(-_bonusLaser, DateTime.Now, "Bonus Laser");
    }
    }
}