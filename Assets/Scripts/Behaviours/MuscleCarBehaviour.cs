using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuscleCarBehaviour : BaseCarBehaviour
{
    private bool _isMoveStarted;
    public override void Move()
    {
        _isMoveStarted = true;
    }

    private void Update()
    {
        if (_isMoveStarted)
        {
            transform.Translate(-1*Time.deltaTime, 0, 0);
        }

    }
}
