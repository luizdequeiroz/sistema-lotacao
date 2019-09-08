using System.Collections.Generic;

namespace api.Models.Repositories.Interfaces
{
    public interface IEstabelecimentoRepository
    {
        IList<Estabelecimento> SelectAll();
        Estabelecimento Insert(Estabelecimento estabelecimento);
        void Delete(int id);
        void Update(Estabelecimento estabelecimento);
        Estabelecimento SelectById(int id);
        IList<Estabelecimento> SelectByName(string name);
    }
}
