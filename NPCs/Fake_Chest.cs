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

namespace UJM.NPCs
{
    public class Fake_Chest : ModNPC
    {
		 private Player player;
        private float speed;	
		
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fake Chest");
        }

        public override void SetDefaults()
		{
			npc.width = 32;
            npc.height = 28;
            npc.damage = 0;
            npc.defense = 25;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCHit4;
            npc.value = 0f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 0;
            aiType = 0; // aiType = 2;
		}
		
		        private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }
		
    public override void NPCLoot()
            {
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, 476);
			}
}}