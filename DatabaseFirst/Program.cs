
using DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (AppDbContext context = new AppDbContext())
{
    var products =await context.Products.ToListAsync();

    products.ForEach(p =>
    {
       

       Console.WriteLine($"{p.Id} Ürün Adı : {p.Name} Fiyat : {p.Price} Stok : {p.Stock}");


    });
}
