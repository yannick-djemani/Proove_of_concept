using Proove_of_concept.Domaines.Entities;
using Proove_of_concept.Infrasctructure.Repositories;

namespace Proove_of_concept.Services
{
    public class ProduitServiceImpl : IProduitService
    {
        private readonly IProduitRepository _produitRepository;
        public ProduitServiceImpl(IProduitRepository produitRepository)
        {
            _produitRepository = produitRepository;
        }
        public void AddProduct(Produit product)
        {
            _produitRepository.Add(product);
            
        }

        public void DeleteProduct(int id)
        {
            _produitRepository.Delete(id);
              
        }

        public IEnumerable<Produit> GetAllProducts()
        {
            return _produitRepository.GetAll();  
        }

        public Produit GetProductById(int id)
        {
            return _produitRepository.GetById(id);  
        }

        public void UpdateProduct(Produit product)
        {
            _produitRepository.Update(product);
            
        }
    }
}
