using LiteDB;
using Trolls2.Modelos;

namespace Trolls2;

public class BaseControle
{
  //----------------------------------------------------------------------------

  protected string NomeDaTabela;
  protected static LiteDatabase liteDB = null;

  //----------------------------------------------------------------------------

  public BaseControle()
  {
    var pathToPersonalFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TROLLS.db");

    if (liteDB == null)
      liteDB = new LiteDatabase(@"filename=" + pathToPersonalFolder + "; upgrade=true; Mode=Exclusive");
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Registro r)
  {
  }
  
  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
  }
  
  //----------------------------------------------------------------------------

  public virtual Registro Ler(int id)
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual List<Registro>? LerTodos()
  {
    return null;
  }

  //----------------------------------------------------------------------------
}