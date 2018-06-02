using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class log : MonoBehaviour {

    public Transform pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        System.Console.WriteLine(pos.position.x.ToString() + " " + pos.position.y.ToString() + " " + pos.position.z.ToString());
	}
}
