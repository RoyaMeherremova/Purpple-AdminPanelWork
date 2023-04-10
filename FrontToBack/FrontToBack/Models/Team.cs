namespace FrontToBack.Models
{
    public class Team:BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<TeamMember> TeamMembers { get; set; }

    }
}
