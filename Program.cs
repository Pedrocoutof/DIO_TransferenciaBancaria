
List<Pessoa> pessoas;
pessoas = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa("Pedro", DateTime.Parse("15/03/2001"));
Pessoa pessoa2 = new Pessoa("João", DateTime.Parse("20/11/1997"));

pessoa1.adicionaSaldo(10000);
pessoa2.adicionaSaldo(20000);

pessoas.Add(pessoa1);
pessoas.Add(pessoa2);


void adicionaPessoa(){
    Console.WriteLine("Digite o nome: ");
    string nome = Console.ReadLine()!;
    Console.WriteLine("Digite sua data de nascimento:");
    DateTime dataNascimento = DateTime.Parse(Console.ReadLine()!);
    Pessoa pessoa = new Pessoa(nome, dataNascimento);
    pessoas.Add(pessoa);
}

void ImprimePessoasRegistradas(){
    if(pessoas.Count > 0)
    for(int i = 0 ; i < pessoas.Count; i++){
        pessoas[i].imprimeInfos();
    }else{
        Console.WriteLine("Nenhuma pessoas registrada");
    }
}

void transferirDinheiro(){
    if(pessoas.Count >= 2){
        Console.WriteLine("Digite o nome da pessoa que ira transferir seu dinheiro:");
        string nomeTransfere = Console.ReadLine()!;

        for(int i = 0; i < pessoas.Count; i++){
            if(Equals(pessoas[i].getNome(), nomeTransfere)){
                Console.WriteLine("Digite o nome da pessoa que ira receber o dinheiro:");
                string nomeRecebe = Console.ReadLine()!;
                for(int j = 0; j < pessoas.Count; j++){
                    if(Equals(pessoas[j].getNome(), nomeRecebe)){
                        Console.WriteLine("Digite o valor a ser depositado");
                        double valor = double.Parse(Console.ReadLine()!);
                        pessoas[i].trasferencia(pessoas[j], valor);
                        return;
                    }
                        

                }
            }
        }
    }
        Console.WriteLine("\nPessoa nao encontrada!\n");

}

void sacar(){
    if(pessoas.Count >= 1){
        Console.WriteLine("Digite o nome da pessoa que ira sacar:");
        string nome = Console.ReadLine()!;
        for(int i = 0; i < pessoas.Count; i++){
            if(Equals(pessoas[i].getNome(), nome)){
                Console.WriteLine("Digite o valor que deseja remover:");
                double valor = double.Parse(Console.ReadLine()!);
                pessoas[i].removeSaldo(valor);
                return;
    }
    Console.WriteLine("\nPessoa nao encontrada!\n");
}
}
}

void depositar(){
    if(pessoas.Count >= 1){
        Console.WriteLine("Digite o nome da pessoa que ira depositar:");
        string nome = Console.ReadLine()!;

        for(int i = 0; i < pessoas.Count; i++){
            if(Equals(pessoas[i].getNome(), nome)){
                Console.WriteLine("Digite o valor que deseja adicionar:");
                double valor = double.Parse(Console.ReadLine()!);
                pessoas[i].adicionaSaldo(valor);
                return;
    }
    
    }

}else{
    Console.WriteLine("\nPessoa nao encontrada!\n");
}
}



int opcao;

do{
    Console.WriteLine(" === Menu Principal === ");
    Console.WriteLine(" 1 - Adicionar pessoa");
    Console.WriteLine(" 2 - Imprimir pessoas registradas");
    Console.WriteLine(" 3 - Transferir dinheiro");
    Console.WriteLine(" 4 - Sacar");
    Console.WriteLine(" 5 - Depositar");
    Console.WriteLine(" 6 - Sair");

    opcao = int.Parse(Console.ReadLine()!);

    if(opcao == 1){
        adicionaPessoa();
    }
    if(opcao == 2){
        ImprimePessoasRegistradas();
    }
    if(opcao == 3){
        transferirDinheiro();
    }
    if(opcao == 4){
        sacar();
    }
    if(opcao == 5){
        depositar();
    }
}while(opcao != 6);





