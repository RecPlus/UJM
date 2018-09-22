using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UJM.Items {
public class Wildura : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wildubra Venum");
			Tooltip.SetDefault("Casts Homing Projectiles\nHas a low chance to fire a powerful projectile that does the double of damage than normal\nprojectiles and it can does multiple damage with the same projectile");
			Item.staff[item.type] = true;
		}
    public override void SetDefaults()
    {
		item.UseSound = SoundID.Item43;
				item.useStyle = 5;
				item.autoReuse = true;
				item.noMelee = true;
				item.magic = true;
				item.mana = 15;
				item.damage = 45;
				item.knockBack = 3;
                item.useTime = 13;
                item.useAnimation = 13;
				item.shoot = mod.ProjectileType("Wildura_Spike");
                item.shootSpeed = 15f;
        item.width = 50;
        item.height = 50;
        item.value = Item.sellPrice(0, 8, 0, 0);
        item.rare = 6;
    }
	
	 public override bool CanUseItem(Player player)
        {
            if (Main.rand.NextFloat(25) < 1)
            {
				item.useStyle = 5;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 90;
				item.knockBack = 3;
                item.useTime = 13;
				item.UseSound = SoundID.Item43;
                item.useAnimation = 13;
				item.shoot = mod.ProjectileType("Wildura_Spike_Ex");
                item.shootSpeed = 20f;
            } 
			else
            {
				item.useStyle = 5;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 60;
				item.knockBack = 3;
                item.useTime = 13;
				item.UseSound = SoundID.Item43;
				item.shoot = mod.ProjectileType("Wildura_Spike");
				item.shootSpeed = 15f;
                item.useAnimation = 13;
            }
		         return base.CanUseItem(player);
        }
	
	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
    }
}