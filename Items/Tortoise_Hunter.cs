using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UJM.Items {
public class Tortoise_Hunter : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tortoise Hunter");
			Tooltip.SetDefault("Musket Balls changes into Darts with infinite npc penetration");
		}
    public override void SetDefaults()
    {
		item.crit = 15;
        item.damage = 130;
        item.ranged = true;
        item.width = 82; 
        item.height = 28; 
        item.useTime = 40;
        item.useAnimation = 40;
        item.useStyle = 5; 
        item.noMelee = true;
        item.knockBack = 5;
        item.rare = 6;
        item.value = Item.sellPrice(0, 8, 0, 0);
        item.UseSound = SoundID.Item36; 
        item.autoReuse = false;
        item.shoot = 10; 
        item.shootSpeed = 35f;
        item.useAmmo = AmmoID.Bullet;
    }
	
	public override Vector2? HoldoutOffset()
		{
			return new Vector2(-6, 0);
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
				type = mod.ProjectileType("Shield_Penetrator"); // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}
}   }