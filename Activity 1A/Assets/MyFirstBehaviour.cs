using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstBehaviour : MonoBehaviour {
	public int repeatNo = 10;
	public int count = 500;
	// Use this for initialization
	void Start () {
		Debug.Log("Hello World");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(transform.position);
		if (count % 50 == 0) {
			Debug.Log (repeatNo);
			repeatNo--;
		}
		if (count > 1) {
			count--;
		}
	}
}
