namespace PersonsInfo
{
    using System.Collections.Generic;
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reservTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reservTeam = new List<Person>();
        }
        public string Name { get; private set; }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get => this.firstTeam;
        }
        public IReadOnlyCollection<Person> Reserv
        {
            get => this.reservTeam;
        }
        public void AddPlayer(Person player)
        {
            if(player.Age<40)
            {
                firstTeam.Add(player);

            }
            else
            {
                reservTeam.Add(player);
            }
        }
    }
}
