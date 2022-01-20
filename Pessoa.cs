
public class Pessoa{
    string nome;
    private DateTime dataNascimento;
    private ContaBancaria contaBancaria;
    public Pessoa(string nome, DateTime dataNascimento){

        if(nome != null){
            this.nome = nome;
        }else{
            throw new ArgumentNullException("Nome informado nulo");
        }

        this.dataNascimento = dataNascimento;

        if(verificaMaioridade()){
            contaBancaria = new ContaBancaria(this);
            Console.WriteLine("Conta Criada!");
        }else{
            throw new ArgumentException("Esta pessoa nao e de maior");
        }

    }
    private bool verificaMaioridade(){
        DateTime dataAtual = DateTime.Today;

        if(dataAtual.Year - dataNascimento.Year >= 18){
            if(dataAtual.Month - dataNascimento.Month <= 0)
                return true;
                    
        }
        
        return false;
        
    } 


    public void imprimeInfos(){
        Console.WriteLine($"\n\nInformacao sobre - {nome}");
        Console.WriteLine($"Data de nascimento: {dataNascimento}");
        Console.WriteLine($"Idade: {DateTime.Now.Year - dataNascimento.Year}  Maioridade: {verificaMaioridade()}");
        Console.WriteLine($"Saldo : {contaBancaria.getSaldo()}\n\n");
    }
    public void trasferencia(Pessoa pessoa, double valor){
        this.contaBancaria.realizaTransacao(pessoa, valor);
    }

    public ContaBancaria getContaBancaria(){
        return this.contaBancaria;
    }


    public void adicionaSaldo(double valor){
        contaBancaria.adicionaSaldo(valor);
    }

    public void removeSaldo(double valor){
        contaBancaria.removeSaldo(valor);
    }

    public string getNome(){
        return this.nome;
    }

    public DateTime getDataNascimento(){
        return this.dataNascimento;
    }

}
