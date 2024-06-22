using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public override void TurnOn()
    {
        _maxSpeed = 200;
        base.TurnOn();
    }
    public override void Move()
    {
        Debug.Log(name + " : moving if base layer road can achieve maxSpeed, else if base layer Sand/grass maxSpeed /= 3 ");
    }
}
