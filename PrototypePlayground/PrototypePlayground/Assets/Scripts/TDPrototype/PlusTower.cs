using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseTower
{
    public class PlusTower : BaseTower
    {
        public PlusTower(Tower t)
        {
            tower = t;
        }

        public override void Tick()
        {
            CoolDown();
        }

        public override void Execute()
        {
            if (firePoints.Length > 0 && projectile != null)
            {
                foreach (Transform point in firePoints)
                {
                    tower.SpawnProjectile(projectile, point);
                }

                currentCoolDownTime = coolDownTime;
            }
            else
                Debug.Log("No Projectile Set");
        }

        public override void SetStats()
        {
            projectile = Resources.Load("TDPrototype/PlusProjectile", typeof(Object)) as GameObject;
            projectileDamage = 2;
            projectileSpeed = 4;
            projectileLifeTime = 5;
            coolDownTime = 2f;
            visionRadius = 7;

            Debug.Log("Set Plus Tower Stats");
        }
    }
}
