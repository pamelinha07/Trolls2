namespace Trolls2;

public class MateriaPrima
{
    string Nome;

   public void SetNome (string Nome) {
      this.Nome = Nome;
   }
    public string GetNome () {
        return this.Nome;
    }

    string UnidadedeMedida;

    public void SetUnidadedeMedida (string UnidadedeMedida) {
        this.UnidadedeMedida = UnidadedeMedida;
    }

    public string GetUnidadedeMedida () {
        return this.UnidadedeMedida;
    }
}