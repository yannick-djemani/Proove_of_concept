using Proove_of_concept.Domaines.Entities;
namespace Proove_of_concept.Infrasctructure.Repositories
{
    public interface IProduitRepository
    {
        IEnumerable<Produit> GetAll();
        Produit GetById(int id);
        void Add(Produit produit);
        void Update(Produit produit);
        void Delete(int id);
    }
}
