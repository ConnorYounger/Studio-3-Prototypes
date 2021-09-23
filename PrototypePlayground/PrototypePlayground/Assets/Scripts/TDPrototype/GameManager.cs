using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseTower
{
    public class GameManager : MonoBehaviour
    {
        [Header("Towers")]
        public List<Tower> towers;

        [Header("Enemies")]
        //public GameObject debugEnemy;
        //public Transform enemySpawnPoint;

        public TDEnemySpawnManager enemySpawnManager;

        public bool radiusCheck = true;

        // Start is called before the first frame update
        void Start()
        {
            RadiusCheck(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnGUI()
        {
            if (GUI.Button(new Rect(25, 25, 100, 30), "Spawn Enemy"))
                SpawnEnemy();

            if (GUI.Button(new Rect(25, 75, 150, 30), "Tower Radius Check"))
                RadiusCheck(true);
        }

        void RadiusCheck(bool switchValue)
        {
            if (switchValue)
                radiusCheck = !radiusCheck;

            if(towers.Count > 0)
            {
                foreach(Tower t in towers)
                {
                    t.RadiusCheck(radiusCheck);
                }
            }
        }

        void SpawnEnemy()
        {
            //if(enemySpawnPoint && debugEnemy)
            //{
            //    Instantiate(debugEnemy, enemySpawnPoint.position, enemySpawnPoint.rotation);
            //}

            enemySpawnManager.SpawnEnemy();
        }
    }
}
