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



		[Header("[i:267]  Town NPCs")] 
		[Label("[i:757]  Item Damage")]
        [Tooltip("on = Items will damage Town NPCs\n" +
		"off = Items will dont damage Town NPCs")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool TownI { get; set; }

		[Label("[i:3568]  Projectiles damage")]
		 [Tooltip("on = Projectiles will damage Town NPCs\n" +
		"off = Projectiles will dont damage Town NPCs")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool TownP { get; set; }

		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
		{
			return true;
		}

	}
}