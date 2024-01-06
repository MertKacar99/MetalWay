using MetalWay.Models;

namespace MetalWay.Models;

public class Repository(){
  private static readonly List<Product> _products = new();
  private static readonly List<Category> _categories = new();      
   
 
    //! ekleme işlemi
    static Repository(){
        _categories.Add(new Category(){CategoryId = 1, CategoryName = "T-Shirt"});
        _categories.Add(new Category(){CategoryId = 2, CategoryName = "Hoodie"});
  
       _products.Add(new Product {ProductId=1, Name = "As I Lay Dying Tshirt", Price = 600, IsActive = true,Image = "asilayT.jpg",CategoryId = 1 });
       _products.Add(new Product {ProductId=2 , Name= "Bullet For My Valentine Tshirt", Price =560,IsActive=true,Image="BfmvT.jpg",CategoryId=1});  
       _products.Add(new Product {ProductId=3 , Name= "Megadeth Tshirt", Price =700,IsActive=true,Image="megadethT.jpg",CategoryId=1}); 
       _products.Add(new Product {ProductId=4 , Name= "Trivium Tshirt", Price =560,IsActive=true,Image="TriviumT.jpeg",CategoryId=1});  
       _products.Add(new Product {ProductId=5 , Name= "Iron Madiden Tshirt", Price =560,IsActive=true,Image="ıronmaidents.png",CategoryId=1});  
       _products.Add(new Product {ProductId=6 , Name= "As I Lay Dying Hoodie", Price =1500,IsActive=true,Image="asIlaydyingHoodie.jpeg",CategoryId=2});
       _products.Add(new Product {ProductId=7 , Name= "Slipknot Hoodie", Price =1600,IsActive=true,Image="slipknotHoodie.jpeg",CategoryId=2});
       _products.Add(new Product {ProductId=8 , Name= "Slayer Hoodie", Price =1600,IsActive=true,Image="slayerh.jpg",CategoryId=2});


        

    }
         public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

           public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null) 
            {
                if(!string.IsNullOrEmpty(updatedProduct.Name)) 
                {
                    entity.Name = updatedProduct.Name;
                }
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static void EditIsActive(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null) 
            {
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);

            if(entity != null) 
            {
                _products.Remove(entity);
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

}
 