using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : Vehicle
{
    public override void TurnOn()
    {
        _maxSpeed = 50;
        base.TurnOn();
    }
    public override void Move()
    {
        Debug.Log(name + " : if base layer is Water");
    }
}
