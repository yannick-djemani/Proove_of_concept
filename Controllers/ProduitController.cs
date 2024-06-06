
using Microsoft.AspNetCore.Mvc;
using Proove_of_concept.Domaines.Entities;
using Proove_of_concept.Services;

namespace Proove_of_concept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }
        /// <summary>
        /// retourne la liste des produits
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetProduits()
        {
            return Ok(_produitService.GetAllProducts());
        }

        /// <summary>
        ///  retourne un produit par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetProduit(int id)
        {
            var produit = _produitService.GetProductById(id);
            if (produit == null)
            {
                return NotFound();
            }
            return Ok(produit);
        }
        /// <summary>
        /// Ajoute un produit
        /// </summary>
        /// <param name="produit"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostProduit([FromBody] Produit produit)
        {
            _produitService.AddProduct(produit);
            return CreatedAtAction(nameof(GetProduit), new { id = produit.Id }, produit);

        }
        /// <summary>
        /// Met à jour un produit
        /// </summary>
        /// <param name="produit"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult PutProduit([FromBody] Produit produit)
        {
            if (produit.Id == 0)
            {
                return BadRequest();
            }
            _produitService.UpdateProduct(produit);
            return NoContent();

        }
        /// <summary>
        /// supprime un produit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _produitService.DeleteProduct(id);
            return NoContent();
        }


    }
}
