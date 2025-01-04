namespace FantasySport.Core.Models
{
    public class Player
    {
        public Guid Id { get; }
        public string Name { get; }
        public Guid? TeamId { get; }
        public bool IsActive { get; }

        private Player(Guid id, string name, bool isActive, Guid? teamId)
        {
            Id = id;
            Name = name;
            TeamId = teamId;
            IsActive = isActive;
        }
        public static (Player Player, string Error) Create(Guid id, string name, bool isActive, Guid? teamId)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                error = "Empty player name";
            }
            var player = new Player(id, name, isActive, teamId);
            return (player, error);
        }
    }
}
