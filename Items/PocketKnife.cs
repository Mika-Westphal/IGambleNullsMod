using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Audio;

namespace IGambleNullsMod.Items
{
    class PocketKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pocket Knife");
            Tooltip.SetDefault("It's dangerous to go alone. Take this!");
        }

        public override void SetDefaults()
        {
            item.damage = 350;
            item.melee = true;
            item.width = 15;
            item.height = 15;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.knockBack = 10;
            item.crit = 11;
            item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.TitaniumBar, 10);
            recipe.AddIngredient(ItemID.RedBrick, 10);
            recipe.AddIngredient(ItemID.Diamond, 10);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
