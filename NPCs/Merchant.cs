using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace DespawnAbleTownNpcs.NPCs
{

	public class Merchant : GlobalNPC //its just works
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<DespawnAbleTownNpcsConfigServer>().TownP == false;
		}

		public override bool? CanBeHitByProjectile(NPC npc, Projectile projectile) //does same but with projectiles
		{
		//	if (GetInstance<DespawnAbleTownNpcsConfigServer>().TownP == false)
			{
				return true;
			}
		}

	}
}