using System;

class Program
{
    static void Main(string[] args)
    {
        // --------- WARHAMMER 40k PROJECT ---------

        //// Instantiate Objects
        /// SpaceMarines
        Imperium ultramarines = new SpaceMarines("Ultramarines", "Roboute Gulliman", "For Ultramar!", "The tride and true staple of the Space Marines - this legion has the most amount of Adeptus Astartes Successor Chapters.", "Robuoute Gulliman", 73.5);
        Imperium blackTemplars = new SpaceMarines("Black Templars", "Rogal Dorn", "No pity! No remorse! No fear!", "A crusading child-legion of the Imperial Fists, organized to crush foes with overwhelming force.", "High Marshal Helbrecht", 60);
        Imperium bloodAngels = new SpaceMarines("Blood Angels", "Sanguinius", "Death to Horus!", "A legion of nobility, artistic spirit, and a tragic curse...", "Baal Predator", 80);
        Imperium darkAngels = new SpaceMarines("Dark Angels", "Lion El'Jonson", "Repent! For tomorrow you die!", "A legion of staunch defenders that are shrouded in mystery, myth, and secrets.", "Lion El'Jonson", 73.5);
        Imperium salamanders = new SpaceMarines("Salamanders", "Vulkan", "Into the fires of battle, unto the Anvil of War!", "More concerned for humanity than the average chapter, this legion strives to protect the innocent.", "Saturnine Predator", 53);
        Imperium ironHands = new SpaceMarines("Iron Hands", "Ferrus Manus", "The flesh is weak!", "A legion obsessed with enhancing themselves through cybernetic augmentation.", "Ferrus Manus, Primarch of the Iron Hands", 132);
        Imperium spaceWolves = new SpaceMarines("Space Wolves", "Leman Russ", "For Russ and the Allfather!", "Ferocious warriors that ride on wolves into battle. They aim to cut the head from the snake.", "Hvarl Red-Blade - Jarl of the Fourth Great Company", 90);
        
        /// AstraMilitarum
        Imperium cadia = new AstraMilitarum("Cadian Guard", "Cadia", "Cadia stands!", "Remembered for their adaptability and vigilent spirit in the defense of their homeworld, the Cadian Guard is one of the most highly respected regiments.", "Lord Castellan Ursula Creed", 48);
        Imperium catachan = new AstraMilitarum("Catachan Jungle Fighters", "Militarum Regimentum", "If it walks, we can drop it.", "Super-survivalists of their jungle death world, these warriors specialize in jungle warfare, ambushes, and guerilla tactics.", "Catachan Command Squad", 39);
        Imperium krieg = new AstraMilitarum("Death Korps of Krieg", "Krieg", "In life, war. In death, peace. In life, shame. In death, atonement.", "After a rebellion on their home planet of Krieg, this regiment aims to atone for their world's mistakes through dedication and sacrifice.", "Lord Marshal Dreir", 60);
        
        /// ChaosMarines
        Chaos worldEaters = new ChaosMarines("World Eaters", "Khorne", "Angron", "Blood for the blood god! Skulls for the skull throne! Death to the False Emperor!", "A brutal traitor legion that defected to the god of blood and destruction.", "Angron - Daemon Primarch of Khorne", 175);
        Chaos thousandSons = new ChaosMarines("Thousand Sons", "Tzeentch", "Magnus the Red", "All is Dust!", "Twisted by a dark spell, this traitor legion was evaporated into dust and is now bound to their armor... and the daemon god of sorceries and change.", "Magnus the Red - Daemon Primarch of Tzeentch", 175);
        Chaos deathGuard = new ChaosMarines("Death Guard", "Nurgle", "Mortarion", "...", "A traitor legion that was corrupted by one of their own from the inside, causing the loss of their voices. They are bound to the god of death and plagues.", "Mortarion - Daemon Primarch of Nurgle", 175);
        Chaos emperorsChildren = new ChaosMarines("Emperor's Children", "Slaanesh", "Fulgrim", "Children of the Emperor! Death to his foes!", "This traitor legion that fearlessly mocks the Imperium in battle as they follow the god of excess.", "Fulgrim - Daemon Primarch of Slaanesh", 175);

        /// Xenos
        Faction tyranids = new Xenos("Tyranids", "*NOM NOM NOM*", "Swarms of biological killing-machines, the Tyranids answer only to hunger and the almighty Hive Mind.", "Tyranid Hierophant Bio-Titan", 535);
        Faction orks = new Xenos("Orks", "WAAAAAAAAAAGH!", "Strong, dim, and cockney green monster-men that only live for one thing: lots of orky violence.", "Ork Gargantuan Squiggoth", 530);
        Faction aeldari = new Xenos("Aeldari", "For the tears of the living, and the souls of the dead!", "A highly advanced race of elves that are quick in both mind and feet.", "Wraithknight", 170);
        Faction necrons = new Xenos("Necrons", "...", "An age-old race of metal warriors that sold their souls for immortality.", "Seraptek Heavy Construct", 400);
        Faction tau = new Xenos("T'au Empire", "For the Greater Good!", "A once-small civilization that grew technology from sticks and stones to armored mechs and battlesuits.", "T'au Tiger Shark AX-1-0'", 330);
        
        /// Dictionary for GetsAlongWith
        Dictionary<string, Faction> armies = new Dictionary<string, Faction>()
        {
            // Space Marines
            {"ultramarines", ultramarines},
            {"black templars", blackTemplars},
            {"blood angels", bloodAngels},
            {"dark angels", darkAngels},
            {"salamanders", salamanders},
            {"iron hands", ironHands},
            {"space wolves", spaceWolves},

            // Astra Militarum
            {"cadian guard", cadia},
            {"catachan jungle fighters", catachan},
            {"death korps of krieg", krieg},

            // Chaos Marines
            {"world eaters", worldEaters},
            {"thousand sons", thousandSons},
            {"death guard", deathGuard},
            {"emperor's children", emperorsChildren},

            // Xenos
            {"tyranids", tyranids},
            {"orks", orks},
            {"aeldari", aeldari},
            {"necrons", necrons},
            {"t'au empire", tau}
        };

        // Clean up terminal for program (Putting it in the loop causes problems)
        Console.Clear();
        bool running = true;

        try
        {         
            while (running)
            {
                /// MENU
                // Introduction
                Console.WriteLine("------------ Warhammer 40k Army Viewer ------------");
                Console.WriteLine("     \"In the grim-darkness of the far future,");
                Console.WriteLine("              there is only war.\"\n");
                Console.WriteLine("Explore factions, armies, and see if they get along!\n");
                Console.WriteLine("--------------- Warhammer Factions ----------------");
                Console.WriteLine("1. Imperium");
                Console.WriteLine("2. Chaos");
                Console.WriteLine("3. Xenos");
                Console.WriteLine("---------------------------------------------------\n");
                Console.WriteLine("4. Who Gets Along");
                Console.WriteLine("5. Quit\n");

                int choice = UI.ReadInt("Select a number: ");
                Console.WriteLine();

                switch (choice)
                {
                    // IMPERIUM
                    case 1:
                        Console.WriteLine("------------ Imperium of Man ------------");
                        Console.WriteLine("          \"For the Emperor!\"");
                        Console.WriteLine(" The galaxy-spanning empire of humanity,");
                        Console.WriteLine("        ruled by the God Emperor.");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("1. Space Marines");
                        Console.WriteLine("2. Astra Militarum\n");
                        
                        int impChoice = UI.ReadInt("Select a number: ");
                        Console.WriteLine();

                        switch (impChoice)
                        {
                            // SPACE MARINES
                            case 1:
                                Console.WriteLine("------------ Space Marines ------------");
                                Console.WriteLine("       \"The Emperor Protects!\"");
                                Console.WriteLine("The elite shock troops of the Imperium.");
                                Console.WriteLine("      They are also known as the");
                                Console.WriteLine("           Angels of Death.");
                                Console.WriteLine("---------------------------------------");                            
                                Console.WriteLine(" Each legion's origin stems from their");
                                Console.WriteLine("          a unique Primarch.");
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("1. Ultramarines");
                                Console.WriteLine("2. Black Templars");
                                Console.WriteLine("3. Blood Angels");
                                Console.WriteLine("4. Dark Angels");
                                Console.WriteLine("5. Salamanders");
                                Console.WriteLine("6. Iron Hands");
                                Console.WriteLine("7. Space Wolves");
                                Console.WriteLine("8. Back to Menu\n");                                

                                int smChoice = UI.ReadInt("Select a number: ");
                                Console.WriteLine();

                                switch (smChoice)
                                {
                                    // Ultramarines
                                    case 1:
                                        ultramarines.DisplayInfo();
                                        UI.Pause();                                    
                                        break;
                                    
                                    // Black Templars
                                    case 2:
                                        blackTemplars.DisplayInfo();
                                        UI.Pause();
                                        break;

                                    // Blood Angels
                                    case 3:
                                        bloodAngels.DisplayInfo();
                                        UI.Pause();
                                        break;

                                    // Dark Angels
                                    case 4:
                                        darkAngels.DisplayInfo();
                                        UI.Pause();
                                        break;

                                    // Salamanders
                                    case 5:
                                        salamanders.DisplayInfo();
                                        UI.Pause();
                                        break;
                                        
                                    // Iron Hands
                                    case 6:
                                        ironHands.DisplayInfo();
                                        UI.Pause();
                                        break;

                                    // Space Wolves
                                    case 7:
                                        spaceWolves.DisplayInfo();
                                        UI.Pause();
                                        break;

                                    // Back to Menu
                                    case 8:
                                        break;
                                    
                                    // Catch Potential Invalid Input
                                    default:
                                        Console.WriteLine("-- Invalid Input: [Invalid menu option] --\n");
                                        UI.Pause();
                                        break;
                                }                            
                                break;

                            // ASTRA MILITARUM
                            case 2:
                                Console.WriteLine("------------ Astra Militarum ------------");
                                Console.WriteLine("          \"For the Imperium!\"");
                                Console.WriteLine("Massed infantry, rumbling tanks, and heavy");
                                Console.WriteLine("  artillery have served the Imperium for");
                                Console.WriteLine("           ten thousand years.");
                                Console.WriteLine("-----------------------------------------\n");
                                Console.WriteLine("1. Cadian Guard");
                                Console.WriteLine("2. Catachan Jungle Fighters");
                                Console.WriteLine("3. Death Korps of Krieg");
                                Console.WriteLine("4. Back to Menu\n");                                

                                int amChoice = UI.ReadInt("Select a number: ");
                                Console.WriteLine();

                                switch (amChoice)
                                {
                                    // Cadian Guard
                                    case 1:
                                        cadia.DisplayInfo();
                                        UI.Pause();
                                        break;
                                        
                                    // Catachan Jungle Fighters
                                    case 2:
                                        catachan.DisplayInfo();
                                        UI.Pause();
                                        break;
                                        
                                    // Death Korps of Krieg
                                    case 3:
                                        krieg.DisplayInfo();
                                        UI.Pause();
                                        break;
                                        
                                    // Back to Menu
                                    case 4:
                                        break;
                                    
                                    // Catch Potential Invalid Input
                                    default:
                                        Console.WriteLine("-- Invalid Input: [Invalid menu option] --\n");
                                        UI.Pause();
                                        break;
                                }
                                break;
                            
                            // Catch Potential Invalid Input
                            default:
                                Console.WriteLine("-- Invalid Input: [Invalid menu option] --\n");
                                UI.Pause();
                                break;
                        }
                        break;

                    // CHAOS
                    case 2:
                        Console.WriteLine("---------- The Forces of Chaos ----------");
                        Console.WriteLine("          \"For the Dark Gods!\"");
                        Console.WriteLine("   The Warp is a mirror dimension that");
                        Console.WriteLine("  embodies and grows from it's source: a");
                        Console.WriteLine("  universe at war. It is from this that");
                        Console.WriteLine("     daemons were born, seeking more.");
                        Console.WriteLine("-----------------------------------------\n");
                        Console.WriteLine("1. World Eaters");
                        Console.WriteLine("2. Thousand Sons");
                        Console.WriteLine("3. Death Guard");
                        Console.WriteLine("4. Emperor's Children");
                        Console.WriteLine("5. Back to Menu\n");                        

                        int chaosChoice = UI.ReadInt("Select a number: ");
                        Console.WriteLine();

                        switch (chaosChoice)
                        {
                            // World Eaters
                            case 1:
                                worldEaters.DisplayInfo();
                                UI.Pause();
                                break;
                                
                            // Thousand Sons
                            case 2:
                                thousandSons.DisplayInfo();
                                UI.Pause();
                                break;

                            // Death Guard
                            case 3:
                                deathGuard.DisplayInfo();
                                UI.Pause();
                                break;

                            // Emperor's Children
                            case 4:
                                emperorsChildren.DisplayInfo();
                                UI.Pause();
                                break;
                            
                            // Back to Menu
                            case 5:
                                break;

                            // Catch Potential Invalid Input
                            default:
                                Console.WriteLine("-- Invalid Input: [Invalid menu option] --\n");
                                UI.Pause();
                                break;                        
                        }
                        break;

                    // XENOS
                    case 3:
                        Console.WriteLine("----------- The Xenos Threat ------------");
                        Console.WriteLine("          \"The galaxy is ours!\"");
                        Console.WriteLine(" The galaxy-spanning empire of humanity,");
                        Console.WriteLine("        ruled by the God Emperor.");
                        Console.WriteLine("-----------------------------------------\n");
                        Console.WriteLine("1. Tyranids");
                        Console.WriteLine("2. Orks");
                        Console.WriteLine("3. Aeldari");
                        Console.WriteLine("4. Necrons");
                        Console.WriteLine("5. T'au Empire");
                        Console.WriteLine("6. Back to Menu\n");                    
                        
                        int xChoice = UI.ReadInt("Select a number: ");
                        Console.WriteLine();

                        switch (xChoice)
                        {
                            // Tyranids
                            case 1:
                                tyranids.DisplayInfo();
                                UI.Pause();
                                break;
                                
                            // Orks
                            case 2:
                                orks.DisplayInfo();
                                UI.Pause();
                                break;

                            // Aeldari
                            case 3:
                                aeldari.DisplayInfo();
                                UI.Pause();
                                break;

                            // Necrons
                            case 4:
                                necrons.DisplayInfo();
                                UI.Pause();
                                break;

                            // T'au Empire
                            case 5:
                                tau.DisplayInfo();
                                UI.Pause();
                                break;
                            
                            // Back to Menu
                            case 6:
                                break;
                            
                            // Catch Potential Invalid Input
                            default:
                                Console.WriteLine("-- Invalid Input: [Invalid menu option] --\n");
                                UI.Pause();
                                break;                            
                        }
                        break;

                    // WHO GETS ALONG
                    case 4:
                        Console.WriteLine("------------ Who Gets Along? ------------");
                        Console.WriteLine("Enter the names of two armies and find out");
                        Console.WriteLine("           if they get along!");
                        Console.WriteLine("-----------------------------------------\n");
                        Console.WriteLine("1. Run \"Get Along\" Test");
                        Console.WriteLine("2. Back to Menu\n");                        
                        
                        int getAlongChoice = UI.ReadInt("Select a number: ");

                        switch (getAlongChoice)
                        {
                            // Do They Get Along?
                            case 1:
                                Console.WriteLine("\n------------ Get Along Test ------------");
                                Console.WriteLine("           ENTER YOUR ARMIES   ");
                                Console.WriteLine("-----------------------------------------\n");
                                Console.Write("Enter first army name: ");
                                string army1 = Console.ReadLine().ToLowerInvariant();

                                Console.Write("\nEnter second army name: ");
                                string army2 = Console.ReadLine().ToLowerInvariant();

                                if (army1 == army2)
                                    {
                                        Console.WriteLine("\n-- Invalid Input: [Please enter two unique armies]--\n");
                                        UI.Pause();
                                        break;
                                    }

                                // Check if army1/army2 are in Dictionary
                                if (!armies.TryGetValue(army1, out Faction a) ||
                                    !armies.TryGetValue(army2, out Faction b))
                                {
                                    Console.WriteLine("\n-- Invalid Input: [One or both army names were not recognized]--\n");
                                    UI.Pause();
                                    break;
                                }

                                // Match String Input with Dictionary Value
                                bool result = a.GetsAlongWith(b);
                                Console.WriteLine();
                                Console.Write($"Do they get along?");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(1000);

                                Console.WriteLine($"\n\n{result}!\n");
                                UI.Pause();
                                break;

                            // Back to Menu
                            case 2:
                                break;
                            
                            // Catch Potential Invalid Input
                            default:
                                Console.WriteLine("-- Invalid Input: [Invalid menu option] --\n");
                                UI.Pause();
                                break;
                        }
                        break;

                    // QUIT
                    case 5:
                        Console.WriteLine("Program Quit");
                        running = false;
                        break;
                    
                    // Catch Potential Invalid Input
                    default:
                        Console.WriteLine("-- Invalid Input: [Invalid menu option] --\n");
                        UI.Pause();
                        break;
                }
            }
        }
        // General Catch Exception
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn unexpected error has occurred: {ex.Message}\n");
            Console.WriteLine("Program Quit");
        }
}
    // UI Helper Class for Menu
    public static class UI
    {
        public static void Pause()
        {
            Console.Write("[Press Enter when Ready]");
            Console.ReadLine();
            Console.WriteLine();
        }

        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                
                Console.WriteLine("\n-- Invalid Input: [Please enter a number] --\n");
                Pause();
            }
        }

    }
}
