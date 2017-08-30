using UnityEngine;
using System.Collections;

public class LimiteEscenario : MonoBehaviour {

	public float MinX;
	public float MaxX;
	public float MinY;
	public float MaxY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float x = transform.position.x;
		float y = transform.position.y;

		if (x < MinX)
			x = MaxX;
		else if (x > MaxX)
			x = MinX;

		if (y < MinY)
			y = MaxY;
		else if (y > MaxY)
			y = MinY;

		transform.position = new Vector3(x, y, transform.position.z);
	}
}
