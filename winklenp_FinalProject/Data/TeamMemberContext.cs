namespace FinalProject.data
{
public class TeamMemberContext : DbContext
{
    public TeamMemberContext(DBContextOptions<TeamMemberContext> context){

    }
    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<TeamMemberContext>().HasData(
            new TeamMember {Id=1, FullName="Trish Bard", Birthdate="6/24/2000", Program="Medicine", year="third"},
            new TeamMember {Id=2, Fullname="Winny Drudge", Birthdate="7/15/2004", Program="Biology", year="fourth"},
            new TeamMember {Id=3, FullName="John Apple", Birthdate="8/19/1999", Program="Geology", year="first"}
    

        );
    }

}
}
