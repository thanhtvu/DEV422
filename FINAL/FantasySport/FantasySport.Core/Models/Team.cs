namespace FantasySport.Core.Models
{
    public class Team
    {
        public Guid Id { get; }
        public string Name { get; }

        private Team(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public static (Team Team, string Error) Create(Guid id, string name)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                error = "Empty team name";
            }
            var team = new Team(id, name);
            return (team, error);
        }

    }
}
