﻿using UnityEngine;
using System.Collections;

public class BroomHoops : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("hello1");
        if (col.tag == "Hoop")
        {
            var a = GameManager.instance;
            a.nextHoop();
        }
    }
}
