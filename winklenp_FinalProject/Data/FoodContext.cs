namespace FinalProject.data
{
public class FoodContext : DbContext
{
    public FoodContext(DBContextOptions<FoodContext> context){

    }
    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<FoodContext>().HasData(
            new Food {Id=1, dish="Sausage", location="Germany"},
            new Food{Id=1, dish="Spaghetti", location="italy"},
            new Food {Id=1, dish="Tacos", location="Mexico"}
    

        );
    }
    public DbSet<Job> Jobs {get; set;}

}
}
