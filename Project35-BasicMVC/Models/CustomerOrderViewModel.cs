using System.Reflection;

namespace Project35_BasicMVC.Models
{
    #region 3.view model oluşturma

    //ViewModel, model ve view arasında veri taşımak için kullanılır. CustomerViewModel oluşturuyoruz.
    public class CustomerOrdersViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Order { get; set; }

        //ViewModel, model verilerini ve view'da göstermek için gerekli ek bilgileri bir arada tutacaktır.
    }
}

#endregion
