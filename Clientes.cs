namespace Trolls2;

public class Clientes
{
    string Nome;

    string Telefone;

    string CNPJ;

    string Endereço;
    public void SetNome (string Nome) {
        this.Nome = Nome;
    }
    public void SetTelefone (string Telefone) {
        this.Telefone = Telefone;
    }  
    public void SetCNPJ (string CNPJ)  {
        this.CNPJ = CNPJ;
    }
    public void SetEndereço (string Endereço){
        this.Endereço = Endereço;
    }
    public string GetNome() {
        return Nome;
    }
    public string GetTelefone() {
        return Telefone;
    }
    public string GetCNPJ() {
        return CNPJ;
    }
    public string GetEndereço() {
        return Endereço;
    }
}