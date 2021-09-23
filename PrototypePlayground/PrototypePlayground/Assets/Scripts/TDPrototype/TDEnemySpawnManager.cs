using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDEnemySpawnManager : MonoBehaviour
{
    public GameObject enemy1;

    public Transform enemySpawnPoint;

    public GameObject pathParent;

    private List<Transform> movePoints;

    // Start is called before the first frame update
    void Start()
    {
        movePoints = new List<Transform>();

        if(pathParent.transform.childCount > 0)
        {
            for(int i = 0; i < pathParent.transform.childCount; i++)
            {
                movePoints.Add(pathParent.transform.GetChild(i));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemy1, enemySpawnPoint.position, enemySpawnPoint.rotation);
        
        //for(int i = movePoints.Count - 1; i > 0; i--)
        //{
        //    enemy.GetComponent<TDEnemy>().AddMovePoint(movePoints[i]);
        //}
        enemy.GetComponent<TDEnemy>().SetMovePoints(movePoints);
    }
}
