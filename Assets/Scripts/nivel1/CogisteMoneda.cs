using UnityEngine;
using System.Collections;

public class CogisteMoneda : MonoBehaviour {
            public int puntosAdd=10;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<AudioSource>().playOnAwake = false;
    }
	
	// Update is called once per frame
	void Update () {
    }
    void OnTriggerEnter2D(Collider2D cogiste)
    {
       
        AudioClip clip;
        if (cogiste.gameObject.name == "Player")
        {
            PuntajeController.AgregarPuntos(puntosAdd);
            gameObject.GetComponent<AudioSource>().playOnAwake = false;
            clip = gameObject.GetComponent<AudioSource>().clip;
            AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));
            Destroy(gameObject);

        }
    }
}
