namespace FinalProject.data
{
public class HobbyContext : DbContext
{
    public TeamMemberContext(DBContextOptions<HobbyContext> context){

    }
    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<HobbyContext>().HasData(
            new Hobby {Id=1, type="fishing", cost="low"},
            new Hobby {Id=2, type="aquariums", cost="high"},
            new Hobby {Id=3, type="hiking", cost="low"}
    

        );
    }
    public DbSet<Hobby> Hobbies {get; set;}

}
}
