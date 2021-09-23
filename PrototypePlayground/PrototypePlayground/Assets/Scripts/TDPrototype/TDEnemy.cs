using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDEnemy : MonoBehaviour
{
    private BaseEnemy baseEnemy;

    public List<Transform> movePoints;

    // Start is called before the first frame update
    void Awake()
    {
        movePoints = new List<Transform>();

        baseEnemy = new TDBasicEnemy(this);
        //Debug.Log("Base enemy: " + baseEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        baseEnemy.Tick();

        Movement();
    }

    public void SetMovePoints(List<Transform> list)
    {
        movePoints = list;
    }

    public void AddMovePoint(Transform point)
    {
        movePoints.Add(point);
    }

    public void Movement()
    {
        if (movePoints.Count > 0)
        {
            if (Vector3.Distance(gameObject.transform.position, movePoints[0].position) > .1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, movePoints[0].position, baseEnemy.movementSpeed * Time.deltaTime);
                //enemy.gameObject.transform.position += movePoints[movePoints.Count - 1].position * movementSpeed * Time.deltaTime;
            }
            else
                movePoints.RemoveAt(0);
        }
    }
}
