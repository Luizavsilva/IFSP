using Classes;

var conta1 = new Alimentacao("Luiza", 0);

conta1.EfetuarTransacao(20, DateTime.Now, "Café");
conta1.EfetuarTransacao(50, DateTime.Now, "Compra de Mantimentos");
conta1.ExecutarTransacaoFimdeMes();

Console.WriteLine(conta1.ObterHistoricodeConta());

var conta2 = new Vestuario("Luiza", 0);

conta2.EfetuarTransacao(100, DateTime.Now, "Agasalho");
conta2.EfetuarTransacao(50, DateTime.Now, "Calça");
conta2.EfetuarTransacao(250, DateTime.Now, "Terno");
conta2.ExecutarTransacaoFimdeMes();

Console.WriteLine(conta2.ObterHistoricodeConta());

var conta3 = new Laser("Luiza", 0);

conta3.EfetuarTransacao(200, DateTime.Now, "Cinema");
conta3.ExecutarTransacaoFimdeMes();

Console.WriteLine(conta3.ObterHistoricodeConta());

var conta4 = new Educacao("Luiza", 0);

conta4.EfetuarTransacao(1000, DateTime.Now, "Linguagem C#");
conta4.ExecutarTransacaoFimdeMes();

Console.WriteLine(conta4.ObterHistoricodeConta());