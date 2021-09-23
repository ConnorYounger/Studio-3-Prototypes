using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy
{
    public float movementSpeed = 3;
    public TDEnemy enemy;

    public BaseEnemy()
    {
        //movePoints = new List<Transform>();
    }

    public abstract void Tick();
}
