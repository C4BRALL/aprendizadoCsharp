using byteBank;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Andre Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Silva";
//conta2.conta = "11999-x";
//conta2.numero_agencia = 58;
//conta2.nome_agencia = "Agencia Central";
//conta2.saldo = 100;

//Console.WriteLine("********************* Conta-1 ******************");
//Console.WriteLine($"titular: {conta1.titular}");
//Console.WriteLine($"conta: {conta1.conta}");
//Console.WriteLine($"Numero da Agencia: {conta1.numero_agencia}");
//Console.WriteLine($"Nome da Agência: {conta1.nome_agencia}");
//Console.WriteLine($"Saldo: {conta1.saldo}");
//Console.WriteLine();

//Console.WriteLine("********************* Conta-2 ******************");
//Console.WriteLine($"titular: {conta2.titular}");
//Console.WriteLine($"conta: {conta2.conta}");
//Console.WriteLine($"Numero da Agencia: {conta2.numero_agencia}");
//Console.WriteLine($"Nome da Agência: {conta2.nome_agencia}");
//Console.WriteLine($"Saldo: {conta2.saldo}");
//Console.WriteLine();

double saldo = 100;
double saldo2 = conta1.saldo;

// tipagem por valor
Console.WriteLine(saldo == saldo2);
//Console.WriteLine(saldo == conta1.saldo);



Console.ReadKey();