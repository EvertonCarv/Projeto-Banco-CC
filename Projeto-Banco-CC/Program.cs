// See https://aka.ms/new-console-template for more information
Console.WriteLine("Banco do Grenn");

ContaCorrente contaDoBruno = new ContaCorrente();
contaDoBruno.titular = "Bruno";
contaDoBruno.agencia = 863;
contaDoBruno.numero = 863452;

ContaCorrente contaDaGabriela = new ContaCorrente();
contaDaGabriela.titular = "Gabriela";

Console.WriteLine($"Conta do Bruno {contaDoBruno.saldo}");
Console.WriteLine($"Conta da Gabriela {contaDaGabriela.saldo}");



bool resultadoSaque = contaDoBruno.Sacar(500);
Console.WriteLine(resultadoSaque);


contaDoBruno.Depositar(500);
Console.WriteLine("Saldo após deposito Bruno " + contaDoBruno.saldo);

bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);


Console.WriteLine("Saldo do Bruno " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);
Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

contaDaGabriela.Transferir(100, contaDoBruno);
Console.WriteLine("Saldo do Bruno " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);


