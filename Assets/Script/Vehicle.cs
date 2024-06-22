using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    protected float _maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        TurnOn();
    }

    public virtual void TurnOn()
    {
        Debug.Log("Engine Start");
        Debug.Log("Vehicle Type : " + name + ", Max Speed : " + _maxSpeed);

    }
    public abstract void Move();
    private void OnMouseDown()
    {
        Move();
    }
    private void OnMouseUp()
    {
        TurnOff();
    }
    public void TurnOff()
    {
        Debug.Log("Engine off, due to fuel level");
    }
}
