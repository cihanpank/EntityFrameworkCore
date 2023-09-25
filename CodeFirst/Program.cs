using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (AppDbContext context =new())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} Ürün Adı : {p.Name} Fiyat : {p.Price} Stok : {p.Stock}");
    });
}