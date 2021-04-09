using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Obamium.Items
{
    public class BidenBoomerang : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Legendary boomerang that biden used to pvp saddam into hell");
        }

        public override void SetDefaults()
        {
            item.damage = 300;
            item.noMelee = true;
            item.ranged = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 25;
            item.useAnimation = 25;
            item.noUseGraphic = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 25;
            item.value = 100;
            item.rare = ItemRarityID.LightPurple;
            item.shoot = mod.ProjectileType("BidenBoomerangProjectile");
            item.shootSpeed = 12f;
            item.autoReuse = true;

        }

        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
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
