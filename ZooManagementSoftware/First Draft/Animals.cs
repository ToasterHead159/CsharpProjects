using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ZooManageEncycloFA2
{
    //interface for moving an animal between enclosures.
    public interface IMovable
    {
        //method for checking animal readiness
        bool animalReadytomove(bool aniReady);
        //method for checking enclosure readiness
        bool enclosureReady(bool enclosureReady);
    }
    //base animal class
    public class Animals : IMovable
    {
        //attributes that every animal must have and all share
        protected string aniName = " ";
        protected int aniAge;
        protected string aniGender = " ";

        //constructor for the animal so that animal objects can be made
        public Animals(string aniName, int aniAge, string aniGender)
        {
            this.aniName = aniName;
            this.aniAge = aniAge;
            this.aniGender = aniGender;

        }
        //getters and setters for the attirbutes of the animal.
        public string AniName { get { return aniName; } }
        public int AniAge { get { return aniAge; } }
        public string AniGender { get { return aniGender; } }

        //method for animal eating behaviour in general.
        public static String Eats()
        {
            return "This animal does eat. Select an Animal to see what it eats!";
        }
        //method for animal sleeping behaviour in general.
        public static String Sleep()
        {
            return "This animal needs to sleep. Select an animal to see how much sleep they need!";
        }
        //method for changing the standard price
        public static String ChangePrice()
        {
            return "The Standard Price has changed.";
        }
        //method for changing the seniors price
        public static String ChangePrice(int Age)
        {
            return "The Seniors Price has changed." + "\nSeniors have to be over " + Age + " to qualify.";
        }
        //mthod for changing the childs price.
        public static String ChangePrice(int botAge, int topAge)
        {
            return "The Childs Price has changed." + "\nOnly children between " + botAge + " and " + topAge + "\ncan qualify for child pricing.";
        }
        //movement method for animal
        public bool animalReadytomove(bool aniReady)
        {
            if (aniReady == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //movmeent method for the enclosure
        public bool enclosureReady(bool enclosureState)
        {
            if (enclosureState == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //lion subclass of the animals base class
    public class Lion : Animals
    {
        //attribute unique to lions.
        private Boolean hasMane;
        //constructor for the lion inheriting the attributes from the base class.
        public Lion(string aniName, int aniAge, string aniGender, bool hasMane) : base(aniName, aniAge, aniGender)
        {
            this.hasMane = hasMane;
        }
        //getter and setter for if the lion has a mane or not.
        public bool HasMane { get { return hasMane; } }
        //method for lions specific eating behaviour.
        public static string Eats()
        {
            return "This lions diet consists of meat! They do not eat veggies!";
        }
        //method for lions specific sleep behaviour.
        public static string Sleep()
        {
            return @"Male lions spend 18 to 20 hours a day snoozing, while females get 15 to 18 hours of shuteye. 
The lionesses spend more time hunting and taking care of cubs, which is why they get slightly less sleep. 
And following a large meal, lions may even sleep up to 24 hours—talk about a catnap!";
        }
        //extend information on lions. used in the moreinfo form.
        public static String lionInfo()
        {
            String theInfo = @"Here are five interesting facts about lions:

Lions are unique among big cats for their social behavior. 
They live in groups called prides, which typically consist of related females and their young, along with a few adult males. 
This social structure helps them defend territory and cooperate in hunting.

Male lions are known for their distinctive mane, which varies in color and length depending on genetics and environmental factors. 
The mane serves as a sign of dominance and protection during fights with other males.
Lions are famous for their powerful roar, which can be heard up to 5 miles (8 kilometers) away. 
Roaring is used to communicate within the pride, intimidate rivals, and establish territory boundaries.

Lions are territorial animals, and prides defend their territory from other prides. 
The size of a pride's territory depends on factors like prey availability and competition with neighboring prides.

Lions are apex predators and primarily hunt large herbivores such as zebras, wildebeests, and buffalo. 
Lionesses (female lions) are the primary hunters, using teamwork to bring down prey with coordinated strategies like ambushes and group chases.";
            return theInfo;
        }
    }
    //parrot subclass of animal class.
    public class Parrot : Animals
    {
        //single attribute unique to parrots
        string featherColor;
        //contructor for the parrot inheriting from the parent.
        public Parrot(string aniName, int aniAge, string aniGender, string featherColor) : base(aniName, aniAge, aniGender)
        {
            this.featherColor = featherColor;
        }

        //getter and setter for the parrot only attribute.
        public string FeatherColor { get { return featherColor; } }
        //parrote specific eating behaviours
        public static string Eats()
        {
            string parEats = "Parrots eat seeds, nuts and berries. No meat for parrots";
            return parEats;
        }
        //parrote specific sleeping behaviours
        public static string Sleep()
        {
            string parSleep = @"Parrots typically need 10 to 12 hours of sleep per night in a quiet and dark environment to maintain health. 
They are diurnal birds, active during the day and resting at night. 
Monitoring sleep behavior and providing consistent routines can help ensure optimal rest and well-being for parrots.";
            return parSleep;
        }
        // extended info for the parrot.not used yet.
        public static string ParrotInfo()
        {
            return @"1. Parrots are exceptionally intelligent birds. They can solve puzzles, use tools, and have demonstrated complex problem-solving abilities. Some species, like African grey parrots, are known for their impressive cognitive skills and ability to mimic human speech.
2. Many parrot species are excellent mimics. They can mimic not only human speech but also other sounds they hear in their environment, such as ringing phones, barking dogs, or musical tunes. This ability is due to their unique vocal anatomy.
3. Parrots are among the longest-living bird species. Some large parrots, like macaws and cockatoos, can live for several decades in captivity, with lifespans often ranging from 30 to 80 years or more, depending on the species.
4. Parrots are renowned for their beautiful and vibrant plumage. They come in a stunning array of colors, from brilliant blues and vivid greens to striking reds and yellows. These colors serve as important signals for attracting mates and establishing social hierarchies.
5. Parrots are highly social creatures. In the wild, they often live in large flocks, where they communicate through various vocalizations and body language. They form strong bonds with their mates and offspring, displaying complex social behaviors similar to those observed in primates.";
        }

    }
    //tortoise subclass for animals base class
    public class Tortoise : Animals
    {
        //single attribute unique to a tortoise.
        string shellColor;
        //constructor for the tortoise
        public Tortoise(string aniName, int aniAge, string aniGender, string shellColor) : base(aniName, aniAge, aniGender)
        {
            this.shellColor = shellColor;
        }
        //getter and setter for the tortoises shell color.
        public string ShellColor { get { return shellColor; } }
    }

    //enclosure class used for making objects of enclosures and storing methods
    public class Enclosures : IMovable
    {
        //two universal attributes for the enclosure.
        private string EncName;
        private bool wasCleaned;
        //constructor for the enclosures. 
        public Enclosures(string EncName, bool wasCleand)
        {
            this.EncName = EncName;
            this.wasCleaned = wasCleand;
        }
        //getters and setters for enclosures attributes
        public string encName { get { return EncName; } }
        public bool WasCleaned { get { return wasCleaned; } }
        //method for animal readiness
        public bool animalReadytomove(bool aniReady)
        {

            return true;
        }
        //method for enclosure readiness.
        public bool enclosureReady(bool enclosureState)
        {
            return true;
        }
    }
}
    

