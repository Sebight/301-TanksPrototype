using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Action<float[]> inputEvent;

    public Tank tank;

    private float[] input = new float[2];

    private void Start()
    {
        inputEvent += tank.OnInputChanged;
        
        //This should not be here, but in some sort of GameManager.
        tank.ChangeMovement<Belt>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        input[0] = x;
        input[1] = y;

        inputEvent?.Invoke(input);

        //This would later be rather changed, so it is not hardcoded like this. It was mainly for testing.
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (tank.Movement is Belt)
                tank.ChangeMovement<Hover>();
            else
                tank.ChangeMovement<Belt>();
        }
    }
}
