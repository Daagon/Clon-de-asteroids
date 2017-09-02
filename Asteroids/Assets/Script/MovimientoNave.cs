using UnityEngine;
using System.Collections;
//using WiimoteApi;

public class MovimientoNave : MonoBehaviour {

	//private Wiimote wiimote;

	public float speed;
	private Rigidbody rb;
	public ParticleSystem EfectodeParticulas;
	public AudioSource AudioNaveAvanza;
	public GameObject bala;



	//private ParticleSystem humo;

	// Use this for initialization
	void Start () {

		//humo = GetComponent<ParticleSystem>();
		rb = GetComponent<Rigidbody> ();

		//WiimoteManager.FindWiimotes();
		//WiimoteManager.HasWiimote ();
	}
	
	// Update is called once per frame
	void Update () {

		//if (!WiimoteManager.HasWiimote()) { return; }
		//wiimote = WiimoteManager.Wiimotes[0];
		
		/*int ret;
		do
		{
			ret = wiimote.ReadWiimoteData();
			
			if (ret > 0 && wiimote.current_ext == ExtensionController.MOTIONPLUS) {
				Vector3 offset = new Vector3(  -wiimote.MotionPlus.PitchSpeed,
				                             wiimote.MotionPlus.YawSpeed,
				                             wiimote.MotionPlus.RollSpeed) / 95f; // Divide by 95Hz (average updates per second from wiimote)
				
			}
		} while (ret > 0);*/


		if (Input.GetKey(KeyCode.LeftArrow))
        {//wiimote.Button.d_up
            transform.Rotate(new Vector3 (0,0,3));
		}
		else if (Input.GetKey(KeyCode.RightArrow))
        {//wiimote.Button.d_down
            transform.Rotate(new Vector3 (0,0,-3));
		}

		if (Input.GetKey(KeyCode.UpArrow))
        {//wiimote.Button.d_right
            rb.AddForce (transform.up * speed);

			EfectodeParticulas.Emit(5);

			if(!AudioNaveAvanza.isPlaying/* == false*/)
			{
				AudioNaveAvanza.Play();
			}
		}
		else
		{
			//EfectodeParticulas.Stop();

			AudioNaveAvanza.Stop();
		}

        //bool retardador = true;

		if (Input.GetKeyDown(KeyCode.Space) /*&& retardador == true*/) //wiimote.Button.two
        {
            //retardador = false;
			Instantiate (bala, transform.position,transform.rotation);
            StartCoroutine(elRetraso());
		}
//		if (Input.GetKeyDown (KeyCode.Space)) 
//		{
//			Instantiate (bala, transform.position,transform.rotation);
//		}
	}

    IEnumerator elRetraso()
    {
        yield return new WaitForSeconds(0.1f);
    }

	/*void OnApplicationQuit() {
		if (wiimote != null) {
			WiimoteManager.Cleanup(wiimote);
			wiimote = null;
		}
	}*/


}
