using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseTower
{
    public class Tower : MonoBehaviour
    {
        private BaseTower tower;
        public Transform[] firePoints;

        // Start is called before the first frame update
        void Start()
        {
            tower = new PlusTower(this);
            tower.firePoints = firePoints;
            tower.SetStats();
        }

        // Update is called once per frame
        void Update()
        {
            tower.Tick();
        }

        public void SpawnProjectile(GameObject pro, Transform point)
        {
            GameObject proj = Instantiate(pro, point.position, point.rotation);

            // set pro dmg, speed
            if (proj.GetComponent<Projectile>())
            {
                proj.GetComponent<Projectile>().speed = tower.projectileSpeed;
                proj.GetComponent<Projectile>().damage = tower.projectileDamage;
            }

            StartCoroutine("DestoryProjectile", proj);
        }

        IEnumerator DestoryProjectile(GameObject proj)
        {
            yield return new WaitForSeconds(tower.projectileLifeTime);

            DestroyImmediate(proj, true);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;

            if(tower != null)
                Gizmos.DrawWireSphere(transform.position, tower.visionRadius);
        }

        public void RadiusCheck(bool value)
        {
            tower.radiusCheck = value;
        }
    }
}
