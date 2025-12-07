using System;

class Program
{
    static void Main(string[] args)
    {
        // ------ || WARHAMMER 40k PROJECT || ------
        /// Idea:
        //// - Display factions of the Warhammer 40k Universe
        /// Classes Required:
        //// - Faction Superclass
        //// - Imperium, Chaos, and Xenos Sub-Superclasses
        //// - Subclasses for broader armies under Sub-Superclasses
    
        // Instantiate Objects
        Faction imperium = new ImperiumInfo();
        Faction chaos = new ChaosInfo();
        Faction xenos = new Xenos("Xenos", "The galaxy is ours!", "A diverse group of alien species and armies.", "Tyranid Hierophant Bio-Titan", 535);
        Imperium bloodAngels = new SpaceMarines("Blood Angels", "Sanguinius", "Death to Horus!", "Honorable and noble Space Marines that carry a secret curse...", "Legion Thunderhawk Gunship", 950);
        Imperium krieg = new AstraMilitarum("Imperial Guard", "Death Korps of Krieg", "AhhH! Shovels!!", "After a rebellion on their home planet of Krieg, this regiment aim's to atone for their planet's mistakes through dedication and sacrifice.", "Lord Marshal Dreir", 60);
        Chaos worldEaters = new ChaosMarines("World Eaters", "Khorne", "Angron", "Blood for the blood god! Skulls for the skull throne!", "A brutal, traitorous of Space Marines that have defected to destructive chaos.", "Angron - Daemon Primarch of Khorne", 175);
        
        Console.Clear();
        Console.WriteLine("-----Warhammer 40k Army Viewer-----");
        Console.WriteLine("Blah blah Description blah blah\n");
        Console.WriteLine("   Warhammer 40k Factions:");
        Console.WriteLine("----------------------------");

        bool running = true;

        // MENU [[[WORK IN PROGRESS]]]
        // Only needs to compile , per the assignment.
        // Pressing certain options that aren't currently instantiated are going to cause errors, but NOT "compile" errors so we should be chilling
        while (running)
        {
            Console.WriteLine("1. Humanity/Empire");
            Console.WriteLine("2. Chaos");
            Console.WriteLine("3. Xenos");
            Console.WriteLine("4. Quit\n");
            Console.Write("Select a number: ");
            string decision = Console.ReadLine();
            int choice = int.Parse(decision);
            Console.WriteLine();
            

            if (choice == 1)
            {
                imperium.DisplayInfo();
                Console.WriteLine("1. Space Marines");
                Console.WriteLine("2. Astra Militarum\n");
                Console.Write("Select a number: ");
                string impDecision = Console.ReadLine();
                int impChoice = int.Parse(impDecision);
                Console.WriteLine();

                if (impChoice == 1)
                {
                    Console.WriteLine("----- Space Marines -----");        
                    Console.WriteLine("1. Blood Angels\n");
                    Console.Write("Select a number: ");
                    string smDecision = Console.ReadLine();
                    int smChoice = int.Parse(smDecision);
                    Console.WriteLine();

                    if (smChoice == 1)
                    {
                        bloodAngels.DisplayInfo();                     
                    }
                }
            }

            if (choice == 4)
            {
                running = false;
            }
            
        }


        chaos.DisplayInfo();
        xenos.DisplayInfo();
        krieg.DisplayInfo();
        worldEaters.DisplayInfo();


    }
}