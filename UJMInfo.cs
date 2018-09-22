using System;
using Terraria;
using Terraria.ModLoader;

namespace UJM
{
	public class UJMInfo : GlobalNPC
	{	
	
	public override void NPCLoot(NPC npc)
	{
		if(npc.type == 476)
		{
			int ran = Main.rand.Next(1, 6);
			 if (ran == 1) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Feral_Lance"), 1);
			  if (ran == 2) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Tortoise_Hunter"), 1);
			   if (ran == 3) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Wildura"), 1);
			    if (ran == 4) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 3021, 1);
				 if (ran == 5) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 1162, 1);
				 
				 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 210, Main.rand.Next(5, 7));
				 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 209, Main.rand.Next(7, 15));
				 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 331, Main.rand.Next(10, 20));
				 
				 if(Main.rand.Next(10) < 1)
				{
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 1291);

                }
		}
		
		if (Main.player[Main.myPlayer].ZoneRockLayerHeight)
			if (Main.player[Main.myPlayer].ZoneJungle)
				if(Main.hardMode)
                {
                    if (Main.rand.Next(750) == 1)      //this is the item rarity, so 9 = 1 in 10 chance that the npc will drop the item.
                    {
                       NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, 476);//this is where you set what item to drop ,ItemID.VileMushroom is an example of how to add vanila items , Main.rand.Next(5, 10) it's the quantity,so it will chose a number from 5 to 10
                    }
                }
	}
}}
