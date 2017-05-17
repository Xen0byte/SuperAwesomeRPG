using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAwesomeGameEngine
{
    public class Location
        //Here I specified the class properties and the class constructor along with constructor parameters.
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id, string name, string description, Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
        //Notice that ' = null' has been appended to each of the parameters with class datatypes.
        //Some locations won't have an item required to enter them, a quest available at them, or a monster living there.
        //This lets us call the Location constructor without passing these three values.
        //The constructor will know to use the default values, which, in this case, is the 'null'.

        //Both of these lines would work the same way:
        //Location location = new Location(1, "Your House", "This is your house");
        //Location location = new Location(1, "Your House", "This is your house", null, null, null);
    }
}
