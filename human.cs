using System;
namespace human
{
    public class Human
    {
    // Fields for Human
        public string Name {get;set;}
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        private int health { get; set; }

        // add a public "getter" property to access health
        public int Health 
        {
            get { return Health;}
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength,int intell,int dext,int health)
        {
            this.Name = name;
            this.Strength = strength;
            this.Dexterity = dext;
            this.health = health;
            this.Intelligence = intell;

        }

        /*
        
            Now add a new method called Attack, which when invoked, should reduce the health of a Human object 
            that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, 
            for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
        */
        // Build Attack method
        public int Attack(Human target)
        {
           
            return target.health-(target.Strength * 5);
        }
    }
}
