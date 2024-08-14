using System.Security.Cryptography.X509Certificates;

namespace Trolls2;

public class Acabamentista 
{
    string Nome;

    string Telefone;

    public void SetNome (string Nome) {
        this.Nome = Nome;
    }

    public void SetTelefone (string Telefone) {
    this.Telefone = Telefone;
    }
    public string GetNome() {
     return Nome;
    }

    public string Telefone () {
        return Telefone;
    }


    
}