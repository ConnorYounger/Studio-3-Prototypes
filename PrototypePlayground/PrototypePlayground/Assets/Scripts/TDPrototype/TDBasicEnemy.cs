using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDBasicEnemy : BaseEnemy
{
    public TDBasicEnemy(TDEnemy e)
    {
        enemy = e;

        enemy.movePoints = new List<Transform>();
    }

    public override void Tick()
    {
        //enemy.Movement();
    }
}