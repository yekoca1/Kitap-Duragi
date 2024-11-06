using System;
using KitapDuragi.entity;

public class Comment
{
    public int Id { get; set; }
    public int ProductId { get; set; } // Yorum yapılan ürünün ID'si
    public string UserName { get; set; } // Yorumu yapan kullanıcı adı
    public string Text { get; set; } // Yorum içeriği
    public DateTime CreatedDate { get; set; } = DateTime.Now; // Yorum tarihi
    public Product Product { get; set; } // Yorumun bağlı olduğu ürün
}
