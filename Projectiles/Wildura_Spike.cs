using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UJM.Projectiles
{
	public class Wildura_Spike : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wildura Spike");     //The English name of the projectile
		}

		public override void SetDefaults()
		{
			projectile.timeLeft = 300; 
			projectile.width = 18;      
            projectile.aiStyle = 70;			//The width of projectile hitbox
			projectile.height = 32;              //The height of projectile hitbox          //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.magic = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)         //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.alpha = 50;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 0.5f;            //How much light emit around the projectile
			projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
		}
		
			public override void AI()
		{
			if (Main.rand.Next(3) == 0)
			{
	            	Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 2, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 3, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}
			
					public override void Kill(int timeLeft)
				
		{
	            Vector2 position = projectile.Center;
            Main.PlaySound(3, (int)position.X, (int)position.Y);
			int dustnumber = 	Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 3, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 2, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 2, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
            int radius = 20;     //this is the explosion radius, the highter is the value the bigger is the explosion
 
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    int xPosition = (int)(x + position.X / 16.0f);
                    int yPosition = (int)(y + position.Y / 16.0f);
                }
            }
		}
		
				
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)  //how to add a buff to a projectile
        {
            target.AddBuff (20, 600);    //this adds the buff to the npc that got hit by this projectile , 600 is the time the buff lasts
        }

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			{
				projectile.Kill();
			}
			{
				Main.PlaySound(SoundID.Item32, projectile.position);
			}
			return false;
		}
	}
}
