namespace MyRestaurantApp.Models;
public sealed class Product
{
    public int Id { get; set; }
    public string Name { get; set; } //ürün adı
    public decimal Price { get; set; } //Ürün fiyatı
    public List<ProductVariant> ProductVariants { get; set; } //ürün çeşitleri


    //public string Description { get; set; } //Ürün açıklaması
    
}

// seeddata // besleme veri demek. Uygulamanın geliştirme aşamasında besleme verilerle çalışabiliyorum.


//.SqlDataConnection => microsoft//performans olarak en güçlü
//tip güvenli değildir. Sorguların tamamını elle yazmak gerekiyor ve harf hataları dahil bir çok yanlış kodlamaya açık
//daha fazla kod yazarsınız

//Object Relation Mapping => ORM
//--EntityFramework  --- SQLdata ya göre daha az performans
//Tip güvenlidir

// dbfirst --> EntityFramework
