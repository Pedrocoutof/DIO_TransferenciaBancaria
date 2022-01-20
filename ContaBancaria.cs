public class ContaBancaria{

    private Pessoa usuario;
    private double saldo;

    public ContaBancaria(Pessoa usuario){
        this.usuario = usuario;
    }
    public double getSaldo(){
        return this.saldo;
    }
    
    private void imprimeComprovanteDeTransacao(Pessoa pessoa, double valor){

        Console.WriteLine("======= ComprovanteDeTransacao =======");
        Console.WriteLine($"==   De : {this.usuario.getNome()}");
        Console.WriteLine($"==   Para : {pessoa.getNome()}");
        Console.WriteLine($"==   Valor : {valor}");
        Console.WriteLine("======================================");

    }

    public void adicionaSaldo(double saldo){
        if(saldo > 0)
            this.saldo += saldo;
        else{
            throw new InvalidOperationException("Saldo informado para adicao menor ou igual a zero");
        }
        
    }

    public void removeSaldo(double saldo){
        if(saldo > 0)
            this.saldo -= saldo;
        else{
            throw new InvalidOperationException("Saldo informado para remocao menor ou igual a zero");
        }
        
    }

    public void realizaTransacao(Pessoa pessoa, double valor){

        if(valor > saldo){
            throw new InvalidOperationException("Valor de transacao maior que o saldo");
        }else if(valor <= 0){
                throw new InvalidOperationException("Valor de transacao menor ou igual a zero");
        }
        else{
            this.saldo -= valor;
            pessoa.getContaBancaria().adicionaSaldo(valor);
            imprimeComprovanteDeTransacao(pessoa, valor);
        }
    }

}