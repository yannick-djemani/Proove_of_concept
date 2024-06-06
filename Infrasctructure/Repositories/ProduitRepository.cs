using Proove_of_concept.Domaines.Entities;
using Proove_of_concept.Infrasctructure.Data;

namespace Proove_of_concept.Infrasctructure.Repositories
{
    public class ProduitRepository : IProduitRepository

    {
        private readonly AppDbContext _context;

        public ProduitRepository(AppDbContext context)
        {
            _context = context;
        }   
     
        public void Add(Produit produit)
        {
            _context.Produits.Add(produit);
            _context.SaveChanges();
           
        }

        public void Delete(int id)
        {
            var produit = _context.Produits.Find(id);
            if (produit != null)
            {
                _context.Produits.Remove(produit);
                _context.SaveChanges();

            }
  
        }

        public IEnumerable<Produit> GetAll()
        {
            return _context.Produits.ToList();
            
        }

        public Produit GetById(int id)
        {
            return _context.Produits.Find(id);
            
        }

        public void Update(Produit produit)
        {
            _context.Produits.Update(produit);
            _context.SaveChanges();
            
        }
    }
}
