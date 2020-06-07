using IL.Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace DespawnAbleTownNpcs
{
	
	public class DespawnAbleTownNpcsConfigServer : ModConfig
	{
		// You MUST specify a ConfigScope.
		public override ConfigScope Mode => ConfigScope.ServerSide;



		[Header("Town NPCs")] 
		[Label("Town NPCs Items damage")]
		[Tooltip(" on = Items will dont damage Town NPCs , off =  items will damage Town NPCs")]
		[ReloadRequired]
		public bool TownI { get; set; }

		[Label("Town NPCs Projectiles damage")]
		[Tooltip(" on = projectiles will dont damage Town NPCs , off =  projectile will damage Town NPCs")]
		[ReloadRequired]
		public bool TownP { get; set; }

		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
		{
			return true;
		}

	}
}