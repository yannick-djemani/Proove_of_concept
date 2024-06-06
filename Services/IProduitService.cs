using Proove_of_concept.Domaines.Entities;
namespace Proove_of_concept.Services
{
    public interface IProduitService
    {
        IEnumerable<Produit> GetAllProducts();
        Produit GetProductById(int id);
        void AddProduct(Produit product);
        void UpdateProduct(Produit product);
        void DeleteProduct(int id);

    }
}
