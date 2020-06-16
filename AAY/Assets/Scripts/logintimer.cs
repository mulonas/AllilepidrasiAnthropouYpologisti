﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logintimer : MonoBehaviour
{
    public RectTransform mainIconcycle;
    float Step = 0.1f;
    float StepAngle = -36;
    float LOAD = 3f;
    float timefornextscene;
    float startTime;
    public LoadScene LoadNewScene;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        timefornextscene = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime >= Step)
        {
            Vector3 iconAngle = mainIconcycle.localEulerAngles;
            iconAngle.z += StepAngle;

            mainIconcycle.localEulerAngles = iconAngle;

            startTime = Time.time;
        }
        if (Time.time - timefornextscene > LOAD)
        {
            LoadNewScene.SceneLoader(2);
        }
    }
}
