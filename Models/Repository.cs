namespace Asp.NetCore7._0FORMAPP.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly  List<Category> _Categories = new();

        static Repository()
        {
            _Categories.Add(new Category{CategoryId =1 , Name= "Telefon"}); 
            _Categories.Add(new Category{CategoryId =2 , Name= "Bilgisayar"}); 
        }

        public static List<Product> Products
        {
            get 
            { 
                return _products;
            }
        }
        public static List<Category> Categories 
        { 
            get
            {
                return _Categories; 
            } 
        }

    }
}
