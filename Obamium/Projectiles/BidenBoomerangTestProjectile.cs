using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Obamium.Projectiles
{
    public class BidenBoomerangTestProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "BidenBoomerangTestProjectile";
            projectile.width = 30;
            projectile.height = 30;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.magic = false;
            projectile.penetrate = 3;
            projectile.timeLeft = 600;
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;
        }
       /* public override void AI()
        {
            for (int i = 0; i < 200; i++)
            {
                //Enemy NPC variable being set
                NPC target = Main.npc[i];

                //Getting the shooting trajectory
                float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
                float shootToY = target.position.Y - projectile.Center.Y;
                float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                //If the distance between the projectile and the live target is active
                if (distance < 480f && !target.friendly && target.active)
                {
                    if (projectile.ai[0] > 4f) //Assuming you are already incrementing this in AI outside of for loop
                    {
                        //Dividing the factor of 3f which is the desired velocity by distance
                        distance = 3f / distance;

                        //Multiplying the shoot trajectory with distance times a multiplier if you so choose to
                        shootToX *= distance * 5;
                        shootToY *= distance * 5;

                        //Shoot projectile and set ai back to 0
                        Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootToX, shootToY, mod.ProjectileType("BidenBoomerangTestProjectile")
         , 30, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
                        Main.PlaySound(SoundID.Critter, (int)projectile.position.X, (int)projectile.position.Y, 88);
                        projectile.ai[0] = 0f;
                    }
                }
            }
            projectile.ai[0] += 1f;
        } */



    }
}
