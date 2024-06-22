using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : Vehicle
{
    public override void TurnOn()
    {
        _maxSpeed = 600;

        base.TurnOn();
    }
    public override void Move()
    {
        Debug.Log(name + " : is flying");
    }
}
