using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TouchDetector : MonoBehaviour
{
    private void Start()
    {
        StartJumpInputDetect();
    }
    private void StartJumpInputDetect()
    {
        Observable
            .EveryUpdate()
            .Where(x => Input.GetButtonDown("Jump"))
            .Subscribe(x => Debug.Log("Button jump is pressed"))
            .AddTo(this);
    }

    private void StartDoubleJumpDetect()
    {
        var clickStrim = 
            Observable
            .EveryUpdate()
            .Where(x =>Input.GetButtonDown("Jump"));

        clickStrim
            .Buffer(clickStrim)
            .Throttle(TimeSpan.FromMilliseconds(250))
            .Where(x => x.Count >= 2)
            .Subscribe(x => Debug.Log("Button double jump detected"))
            .AddTo(this);
    }
}
