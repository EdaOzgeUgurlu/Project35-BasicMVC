namespace Project35_BasicMVC.Models
{
    #region 2.order model oluşturma

    //order modeli
    //model dosyasında order sınıfı oluşturuyoruz
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }


    }
    #endregion
}
