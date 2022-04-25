using byteBank;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Andre Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 93.50;

//string titular = "Andre Bessa";
//string conta = "10123-x";
//int numero_agencia = 23;
//string nome_agencia = "Agencia Central";
//double saldo = 93.50;

Console.WriteLine($"titular: {conta1.titular}");
Console.WriteLine($"conta: {conta1.conta}");
Console.WriteLine($"Numero da Agencia: {conta1.numero_agencia}");
Console.WriteLine($"Nome da Agência: {conta1.nome_agencia}");
Console.WriteLine($"Saldo: {conta1.saldo}");

Console.ReadKey();