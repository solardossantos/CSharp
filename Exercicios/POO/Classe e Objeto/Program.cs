// Tipo de Referência
// -> Endereço dos dados
Console.WriteLine("Hello World");

class Customer
{
    private string name;
}

class Pagamento
{
    // Propriedades
    public DateTime Vencimento;

    // Métodos
    public void Pagar()
    {
        ConsultarSaldoDoCartao();
    }

    private void ConsultarSaldoDoCartao("34135411")
    {
        
    }

    class PagamentoBoleto : Pagamento
    {
        private DateTime Vencimento;
        
        void Pagar(){ }
    }
    // Eventos
    
}