//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
using RBot;
public class MeateorHunt
{
    public ScriptInterface Bot => ScriptInterface.Instance;
    
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new CoreStory();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        StoryLine();

        Core.SetOptions(false);
    }

    public void StoryLine()
    {
        if (Core.isCompletedBefore(8628))
        {
            Core.Logger("You have already completed this storyline");
            return;
        }
            

        Story.PreLoad();


        //Defeat the Giant ChickenCow 8612

        Story.KillQuest(8612, "MeateorTown", "Giant ChickenCow");


        //Chick Your Surroundings 8614

         if (!Story.QuestProgression(8614))
        {
            Core.EnsureAccept(8614);
            Core.HuntMonster("EarthStorm", "Blue Chick", "Tiny Blue Freggment", 1);
            Core.HuntMonster("Mythsong", "Pink Chick", "Tiny Pink Freggment", 1);
            Core.HuntMonster("WaterStorm", "Purple Chick", "Tiny Purple Freggment", 1);
            Core.HuntMonster("GreenguardWest", "Green Chick", "Tiny Green Freggment", 1);
            Core.HuntMonster("DarkoviaGrave", "Rainbow Chick", "Tiny Rainbow Freggment", 1);
            Core.EnsureComplete(8614);
        }

        //PainFowl Recollection 8615

        Story.KillQuest(8615, "Battlefowl", "Chicken");

        //Empty Nest Syndrome 8616

         if (!Story.QuestProgression(8616))
        {
            Core.EnsureAccept(8616);
            Core.KillMonster("Uppercity", "r2", "Left", 249, "Nested Freggment", 8);
            Core.EnsureComplete(8616);
        }

        //Comet-ted to Memory 8617

        Story.KillQuest(8617, "Comet", "Vaderix");

        //Right Under Your Nose 8618

        Story.KillQuest(8618, "BattleFowl", "ChickenCow");

        //Don't Chicken Out! 8619
        if (!Story.QuestProgression(8619))
        {
            Core.EnsureAccept(8619);
            Core.HuntMonster("BattleFowl", "Sabertooth Chicken", "Pointy Freggment", 8);
            Core.HuntMonster("MeateorTown", "Red Chicken", "Red Freggment", 10);
            Core.HuntMonster("DfLesson", "Chaotic Chicken", "Chaotic Freggment", 6);
            Core.EnsureComplete(8619);
        }
        //Ashville Hot 8620

        Story.KillQuest(8620, "AshfallCamp", new[] { "Infernus", "Blackrawk", "Smoldur",});

        //Holy (Chicken)Cow! 8621

        Story.KillQuest(8621, "CrashRuins", new[] { "Unlucky Explorer", "Cluckmoo Idol"});

        //Chilling Tales of Chicken Cows 8622

        Story.KillQuest(8622 , "northlands", new[] { "Ice Symbiote", "Ice Symbiote"} );

        //Cowissa 8623
        Bot.Quests.UpdateQuest(8000);
        Story.KillQuest(8623, "astravia", "The Moon");

        //Collection Dejection 8624

        Story.KillQuest(8624,"Future", new[] { "The Collector", "The Collector"});

        //Poached Eggs 8625
        
        Story.KillQuest(8625, "byrodax", new[] { "Byro-Dax Monstrosity", "Space Goop", "Mutated Critter",});
 
       //Dumpster Diving 8626

        Story.KillQuest(8626, "Junkhoard", new[] { "Magpie Junk Heap", "Junk Golem", "Magpie",});

       //A Dreadful Dinner 8627

       Story.KillQuest(8627, "Dreadspace", "Troblor");

       //Succeed or Fry Trying 8628

       Story.KillQuest(8628, "thirdspell", new[] { "Great Solar Elemental", "Sun Flare", "Solar Incarnation"});

    }
}