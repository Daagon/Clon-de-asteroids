using UnityEngine;
using System.Collections;

public class AccionBala : MonoBehaviour {

	public float bulletForce;
	private Rigidbody rb;

	public float targetLife;
	private float life;

	private ParticleSystem part;

	// Use this for initialization
	void Start () {

		life = targetLife;

		part = GetComponent<ParticleSystem> ();

		rb = GetComponent<Rigidbody> ();
		rb.AddForce(transform.up * bulletForce);
	}
	
	// Update is called once per frame
	void Update () {

		part.Emit(5);

		life -= Time.deltaTime;
		if(life < 0) Destroy(gameObject);
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Asteroids") {
			Destroy(this.gameObject);
		}
	}
}
