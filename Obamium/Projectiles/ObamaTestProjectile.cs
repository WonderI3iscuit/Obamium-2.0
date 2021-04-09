using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace Obamium.Projectiles
{
    public class ObamaTestProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "ObamaTestProjectile";
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 10;
            projectile.timeLeft = 200;
            projectile.light = 2f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            base.AI();
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}
