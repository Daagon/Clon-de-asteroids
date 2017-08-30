using UnityEngine;
using System.Collections;

public class DestruirNave : MonoBehaviour {

//	public int numVidas = 3;
//	public GameObject ImagenVida1, ImagenVida2, ImagenVida3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Asteroids") {
			Destroy(this.gameObject);
//			QuitarVidas();
		}
	}

//	void QuitarVidas()
//	{
//		if(gameObject == ImagenVida1 || gameObject == ImagenVida2 || gameObject == ImagenVida3)
//		{
//			Destroy(ImagenVida3);
//
//			if(gameObject != ImagenVida3)
//			{
//				Destroy(ImagenVida2);
//				if(gameObject != ImagenVida2)
//				{
//					Destroy(ImagenVida1);
//				}
//			}
//		}
//	}
}