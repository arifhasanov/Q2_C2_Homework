namespace Homework.Data;

public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
        AppDbContext? context = serviceScope.ServiceProvider.GetService<AppDbContext>();
        if (!context.Customers.Any())
        {
            context.Customers.Add(new Customer() { Name = "Johnson & Johnson" });
            context.Customers.Add(new Customer() { Name = "Procter N Gamble" });

            context.SaveChanges();
        }
    }
}
