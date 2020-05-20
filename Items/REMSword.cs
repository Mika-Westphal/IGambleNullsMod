//using IL.Terraria;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Audio;

namespace IGambleNullsMod.Items
{
	public class REMSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("R.E.M Sword");
			Tooltip.SetDefault("Quote spriter David: She is the best waifu of them all.");
		}

		public override void SetDefaults() 
		{
			item.damage = 300;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 7500;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumShortsword, 1);
			recipe.AddIngredient(ItemID.Obsidian, 15);
			recipe.AddIngredient(ItemID.CobaltBar, 30);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			base.MeleeEffects(player, hitbox);
			if (player.statMana >= 10)
				if (Main.rand.NextBool(3))
					Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), 40, 40, 55);
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			base.OnHitNPC(player, target, damage, knockBack, crit);
			if (player.statMana >= 10)
			{
				target.AddBuff(24, 5 * 60);
				player.statMana -= 10;
			}
		}

		public override void OnHitPvp(Player player, Player target, int damage, bool crit)
		{
			base.OnHitPvp(player, target, damage, crit);
			if (player.statMana >= 10)
			{
				target.AddBuff(24, 5 * 60);
				player.statMana -= 10;
			}
		}
	}
}