using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject[] hoops;
    public int cHoop = 0;
    public static GameManager instance;


    // Use this for initialization
    void Start () {
        instance = this;

    }

    // Update is called once per frame
    void Update () { 


	}

    public void nextHoop()
    {
        Debug.Log("NEXTHOOp");
        hoops[cHoop].GetComponent<Renderer>().enabled = false;
        ++cHoop;
        hoops[cHoop].GetComponent<Renderer>().material.color = Color.green;

        //hoops[cHoop].mater
    }
}
