using UnityEngine;
using System.Collections;

public class DestruirNave : MonoBehaviour {

	public static bool toyVivo;
//	public GameObject ImagenVida1, ImagenVida2, ImagenVida3;

	// Use this for initialization
	void Start ()
    {
        toyVivo = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Asteroids") {
            toyVivo = false;
			Destroy(this.gameObject);
		}
	}
}