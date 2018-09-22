using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UJM.Items
{
	public class Key_of_Moss : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moosy Key");
			Tooltip.SetDefault("'Charged with the essence of jungle creatures'");
		}

		// TODO -- Velocity Y smaller, post NewItem?
		public override void SetDefaults()
		{
			Item refItem = new Item();
			item.width = 14;
			item.height = 22;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 0;
			item.useTime = 19;
        item.useAnimation = 19;
        item.useStyle = 5;
		item.autoReuse = false;
		item.consumable = true;
		}
		
		public override bool UseItem(Player player)
    {
		NPC.NewNPC((int)player.position.X, (int)player.position.Y, mod.NPCType("Fake_Chest"));
        return true;
    }
	
	public override void AddRecipes()                
    {                                             
	
     ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(520, 3);
recipe.AddIngredient(521, 3);
recipe.AddIngredient(331, 3);
recipe.AddIngredient(210);
recipe.AddIngredient(209, 3);	
        recipe.SetResult(this);                     
	recipe.AddTile(18);
        recipe.AddRecipe();
	}
	}
}