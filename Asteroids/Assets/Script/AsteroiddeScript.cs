using UnityEngine;
using System.Collections;

public class AsteroiddeScript : MonoBehaviour {

	//public float MinTorque = -600f;
	//public float MaxTorque = 600f;
	//public float MinForce = 2000f;
	//public float MaxForce = 4000f;
	//private float magnitud, x, y;
	private float speedX;
	private float speedY;

	public GameObject NextAsteroid;
	public int NumChildAsteroids = 2;


	//private Rigidbody rb;

	// Use this for initialization
	void Start () {

		/*rb = GetComponent<Rigidbody>();

		magnitud = Random.Range(MinForce, MaxForce);
		x = Random.Range(-1f, 1f);
		y = Random.Range(-1f, 1f);

		rb.AddForce(magnitud * new Vector3(x, y));*/

		//float torque = Random.Range(MinTorque, MaxTorque);
		//rb.AddTorque(torque * new Vector3(x, y));
		speedX = Random.Range(-0.06f, 0.06f);
		speedY = Random.Range(-0.06f, 0.06f);

		//int azar = Random.Range(1, 5);


//		switch(azar)
//		{
//		case 1: transform.position = new Vector3(transform.position.x + speedX, transform.position.y + speedY);
//			break;
//		case 2: transform.position = new Vector3(transform.position.x + speedX, transform.position.y + speedY);
//			break;
//		case 3: transform.position = new Vector3(transform.position.x + speedX, transform.position.y + speedY);
//			break;
//		case 4: transform.position = new Vector3(transform.position.x + speedX, transform.position.y + speedY);
//			break;
//		}
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Vidas.pausa == false)
		transform.position = new Vector3(transform.position.x + speedX, transform.position.y + speedY);

        if (Vidas.pausa == true && GetComponent<AudioSource>() != null)
            GetComponent<AudioSource>().Pause();
        else if(Vidas.pausa == false && GetComponent<AudioSource>() != null)
            GetComponent<AudioSource>().UnPause();

	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Bullet") {

			Destroy(this.gameObject);

			if(NextAsteroid != null)
			{
				for(int i = 0; i<NumChildAsteroids; i++)
				{
					Instantiate(NextAsteroid, transform.position, new Quaternion());
				}
			}


		}
	}


}
