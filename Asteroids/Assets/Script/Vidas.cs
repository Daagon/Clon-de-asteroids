using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour {

	public GameObject nave;
	public GameObject[] imagenVida;
    public GameObject[] asteroides;
    public GameObject instrucciones;
    public GameObject btnSalir, btnReniciar, textPausa;
    public static bool pausa;
    public int vidas;

    private bool menuInstruc;
    private bool victoria;
    private bool revivir;

	// Use this for initialization
	void Start ()
    {
        victoria = false;
        menuInstruc = true;
        revivir = false;
        pausa = true;
        vidas = 3;
	}
	
	// Update is called once per frame
	void Update ()
    {
        asteroides = GameObject.FindGameObjectsWithTag("Asteroids");
        if (asteroides.Length == 0 && victoria == false)
        {
            victoria = true;
            Debug.Log("YA GANASTE");
            btnSalir.SetActive(true);
            btnReniciar.SetActive(true);
        }

        if (vidas > 0)
        {
            if (DestruirNave.toyVivo == false)
            {
                Destroy(imagenVida[vidas]);
                DestruirNave.toyVivo = true;
                revivir = true;
                vidas--;
            }
        }
        if (vidas == 0)
        {
            btnSalir.SetActive(true);
            btnReniciar.SetActive(true);
        }

		if(Input.GetKeyDown(KeyCode.R) && vidas > 0 && revivir == true)
		{
            revivir = false;
			Instantiate (nave);
		}
        if (Input.GetKeyDown(KeyCode.P) && pausa == false && menuInstruc == false)
        {
            Debug.Log("Pausa");
            textPausa.SetActive(true);
            Time.timeScale = 0;
            pausa = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && pausa == true && menuInstruc == false)
        {
            Debug.Log("Quitar pausa");
            textPausa.SetActive(false);
            Time.timeScale = 1;
            pausa = false;
        }
    }

    public void Jugar()
    {
        menuInstruc = false;
        instrucciones.SetActive(false);
        pausa = false;
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
