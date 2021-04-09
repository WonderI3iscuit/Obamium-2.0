using Terraria.ID;
using Terraria.ModLoader;

namespace Obamium.Items
{
	public class The44th : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("ObamaSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Forged from the cloned dna of obama himself");
		}

		public override void SetDefaults() 
		{
			item.damage = 800;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 1;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ObamaTestProjectile");
			item.shootSpeed = 20f;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}