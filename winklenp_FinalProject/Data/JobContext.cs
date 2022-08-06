namespace FinalProject.data
{
public class JobContext : DbContext
{
    public JobContext(DBContextOptions<JobContext> context){

    }
    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<JobContext>().HasData(
            new Job {Id=1, role="Consultant", pay="55k"},
            new Job {Id=1, role="Teacher", pay="37k"},
            new Job {Id=1, role="CEO", pay="800k"}
    

        );
    }
    public DbSet<Job> Jobs {get; set;}

}
}
