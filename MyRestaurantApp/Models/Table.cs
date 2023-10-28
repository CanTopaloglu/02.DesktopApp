namespace MyRestaurantApp.Models;
public sealed class Table
{
    public int Id { get; set; }
    public int Number {  get; set; } // Masa numarası
    public bool IsAvailable { get; set; } // Masa müsait mi?
    public bool IsPayment {  get; set; } //  ödeme yapıldı mı?
    public decimal TotalAmount { get; set; } // toplam tutar
    public decimal PaidAmount{  get; set; } // Ödenmiş tutar
}
