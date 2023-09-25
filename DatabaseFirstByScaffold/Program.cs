using DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

using (UdemEFCoreDatabaseFirtsDbContext context = new())
{
    var data=await context.Products.ToListAsync();
    data.ForEach(d =>
    {
        Console.WriteLine($"Ürün Id: {d.Id} - Ürün Adı: {d.Name} - Ürün Fiyatı : {d.Price} - Stok : {d.Stock}");
    });
} 