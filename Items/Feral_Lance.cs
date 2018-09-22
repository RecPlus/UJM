using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UJM.Items
{
    public class Feral_Lance : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Feral Lance");
		}
        public override void SetDefaults()
        {
            item.damage = 50;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.scale = 1.2f;
            item.maxStack = 1;
            item.useTime = 45;
            item.useAnimation = 45;
            item.knockBack = 5f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.value = Item.sellPrice(0, 8, 0, 0);
            item.rare = 6;
            item.shoot = 568;
            item.shootSpeed = 3f;
        }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("FeralProjectile"), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 567, damage, knockBack, player.whoAmI);
			}
			return false;
		}
    }
}