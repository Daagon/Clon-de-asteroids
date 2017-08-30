using UnityEngine;
using System.Collections;
using WiimoteApi;

public class Vidas : MonoBehaviour {

	public GameObject nave;
	public GameObject vida1, vida2, vida3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		if(nave.gameObject == Destroy(gameObject))
//		{
//			Destroy(vida3);
//		}

		if(Input.GetKeyDown(KeyCode.R))
		{
			Instantiate (nave);
		}
	}
}
