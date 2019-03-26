using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milestone.Models
{
    //Add a "Gender" property? 
    public class Character
    {
        public int characterId { get; set; }
        public String characterName;
        public String classChoice;
        public int health;
        public int attack;
        public String weaponType;
        public int User_Id;

        public void createNewCharacter(String pName, String cChoice, int User_id)
        {
            this.characterName = pName;
            this.classChoice = cChoice;
            this.health = setHealth(cChoice);
            this.attack = setAttack(cChoice);
            this.weaponType = setWeaponType(cChoice);
            this.User_Id = User_id;
        }

        public String getCharacterName()
        {
            return this.characterName;
        }
        public String setCharacterName()
        {
            return this.characterName;
        }

        public String getClassChoice()
        {
            return this.classChoice;
        }
        public String setClassChoice()
        {
            return this.classChoice;
        }

        public int getUser_Id()
        {
            return this.User_Id;
        }

        public int getHealth()
        {
            return this.health;
        }
        public int setHealth(String cChoice)
        {
            if (cChoice == "Mage")
            {
                return 80;
            }
            else if (cChoice == "Archer")
            {
                return 100;
            }
            else if (cChoice == "Saber")
            {
                return 130;
            }

            else if (cChoice == "Berserker")
            {
                return 150;
            }
            else { return 100;  }
        }

        public int getAttack()
        {
            return this.attack;
        }
        public int setAttack(String cChoice) 
        {
            if (cChoice == "Mage")
            {
            return 60;
        }
            else if (cChoice == "Archer")
            {
            return 33;
        }
            else if (cChoice == "Saber")
            {
            return 50;
        }
            else if (cChoice == "Berserker")
            {
            return 150;
        }
            else { return 75; }
        }

        public int getWeaponType()
        {
            return this.attack;
        }
        public String setWeaponType(String cChoice)
        {
            if (cChoice == "Mage")
            {
                return "Staff";
            }
            else if (cChoice == "Archer")
            {
                return "Bow";
            }
            else if (cChoice == "Saber")
            {
                return "Sword";
            }
            else if (cChoice == "Berserker")
            {
                return "Fists";
            }
            else { return "Fists"; }
        }

    }

    public enum Class
    {
        Mage,
        Archer,
        Saber,
        Berserker
    }

}
