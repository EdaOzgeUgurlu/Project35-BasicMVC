### Project35_BasicMVC

#### Proje Hakkında
Bu proje, ASP.NET Core MVC çerçevesini kullanarak temel bir uygulama geliştirme pratiği yapmak amacıyla hazırlanmıştır. **CustomerOrdersController** sınıfı, bir müşteriye ait siparişleri göstermek için oluşturulmuş bir kontrolördür. Model-View-Controller (MVC) mimarisini kullanarak, model ile görünüm arasında bir köprü görevi görür.

---

#### Kullanılan Teknolojiler
- **.NET 7+**
- **ASP.NET Core MVC**
- **C#**
- Razor Görünümleri

---

#### Proje Yapısı
1. **Controllers**  
   - `CustomerOrdersController`:  
     Bu kontrolör, müşteri bilgilerini ve sipariş listesini view'a göndermek için bir `Index` metodu içerir.

2. **Models**  
   - `Customer`: Müşteri bilgilerini (ID, ad, soyad, e-posta) temsil eden sınıf.  
   - `Order`: Bir siparişi (ID, ürün adı, fiyat, miktar) temsil eden sınıf.  
   - `CustomerOrdersViewModel`: Müşteri ve sipariş listesini tek bir view modelde birleştirir.

3. **Views**  
   - `CustomerOrders/Index.cshtml`:  
     Müşteri bilgilerini ve sipariş listesini Razor syntax ile görüntüler. (Bu dosya, projenin view dosyaları altında oluşturulmalıdır.)

---

#### CustomerOrdersController
**CustomerOrdersController** sınıfı şu şekilde çalışır:
1. `Index` metodu:
   - Örnek bir müşteri ve sipariş listesi oluşturur.
   - Bu verileri, `CustomerOrdersViewModel` nesnesi ile view'a iletir.
2. **CustomerOrdersViewModel**:
   - Müşteri bilgilerini ve sipariş listesini içerir.

**Kod Örneği:**  
```csharp
var customer = new Customer
{
    Id = 1,
    FirstName = "Eda",
    LastName = "Ozge",
    Email = "eda.ozge@example.com"
};

var orders = new List<Order>
{
    new Order { Id = 1, ProductName = "Avize", Price = 1500, Quantity = 5 },
    new Order { Id = 2, ProductName = "Masa", Price = 3000, Quantity = 2 },
    new Order { Id = 3, ProductName = "Sandalye", Price = 2000, Quantity = 4 },
    new Order { Id = 4, ProductName = "Koltuk Takımı", Price = 30000, Quantity = 1},
    new Order { Id = 5, ProductName = "Halı", Price = 2800, Quantity = 5 }
};

var viewModel = new CustomerOrdersViewModel
{
    Customer = customer,
    Order = orders
};
return View(viewModel);
```

---

#### Projeyi Çalıştırma
1. Projeyi Visual Studio veya Visual Studio Code ile açın.
2. `CustomerOrdersController` için bir view oluşturun:
   - **Path**: `Views/CustomerOrders/Index.cshtml`
   - İçerik: Müşteri bilgilerini ve sipariş listesini gösteren Razor kodları ekleyin.
3. Projeyi çalıştırın ve tarayıcıda `/CustomerOrders/Index` adresine giderek sonucu görüntüleyin.

---

#### Örnek Görünüm (Index.cshtml)
```html
<h2>Customer Details</h2>
<p>Name: @Model.Customer.FirstName @Model.Customer.LastName</p>
<p>Email: @Model.Customer.Email</p>

<h2>Orders</h2>
<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>Product</th>
            <th>Price</th>
            <th>Quantity</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var order in Model.Order)
        {
            <tr>
                <td>@order.Id</td>
                <td>@order.ProductName</td>
                <td>@order.Price</td>
                <td>@order.Quantity</td>
            </tr>
        }
    </tbody>
</table>
```

---

#### Notlar
- Bu örnek, temel bir proje yapısı ve mantığı göstermek için hazırlanmıştır.
- İsteğe bağlı olarak veri tabanı entegrasyonu, validation işlemleri ve daha fazla özellik eklenebilir.
- Projeyi geliştirirken MVC mimarisinin best practice kurallarına uyulması önerilir.
