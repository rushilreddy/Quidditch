using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var rigid = GetComponent<Rigidbody>();
        rigid.AddForce(new Vector3(100, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
	}
}
