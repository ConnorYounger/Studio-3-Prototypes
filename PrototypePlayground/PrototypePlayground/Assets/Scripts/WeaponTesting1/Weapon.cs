using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    public enum weaponType { defultMelee, chargeMelee, projectile, chargeProjectile };
    public weaponType type;

    public float damage;
    public float attackCooldownTime;

    public abstract void Attack();
}
