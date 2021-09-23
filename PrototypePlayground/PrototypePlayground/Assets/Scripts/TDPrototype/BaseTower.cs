using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseTower
{
    public abstract class BaseTower
    {
        public GameObject projectile;

        public Tower tower;

        public float projectileDamage;
        public float projectileSpeed;
        public float projectileLifeTime;
        public float coolDownTime;
        public float currentCoolDownTime = 1.5f;
        public float visionRadius = 3;

        public Transform[] firePoints;

        public bool radiusCheck = true;

        public abstract void Tick();

        public virtual void Awake()
        {
            currentCoolDownTime = coolDownTime;
        }

        public virtual void SetStats() 
        {
            projectile = Resources.Load("TDPrototype/DefultProjectile", typeof(Object)) as GameObject;
            projectileDamage = 1;
            projectileSpeed = 1;
            projectileLifeTime = 2;
            coolDownTime = 1.5f;

            firePoints = new Transform[1];
            firePoints[0] = tower.transform;

            Debug.Log("Set Defult Stats");
        }

        public virtual void Execute() { }

        public bool VisionCheck()
        {
            Collider[] enemy = Physics.OverlapSphere(tower.transform.position, visionRadius, 1 << 6);

            if (radiusCheck)
            {
                if (enemy.Length > 0)
                {
                    if (enemy[0].GetComponent<TDEnemy>())
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return true;
        }

        public virtual void CoolDown()
        {
            if (currentCoolDownTime > 0)
                currentCoolDownTime -= Time.deltaTime;
            else
            {
                if (VisionCheck())
                {
                    currentCoolDownTime = coolDownTime;
                    Execute();
                }
            }
        }
    }
}
