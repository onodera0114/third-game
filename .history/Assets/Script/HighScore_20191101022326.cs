﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;
    private int HS;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text =HS.ToString ();
    }
}
