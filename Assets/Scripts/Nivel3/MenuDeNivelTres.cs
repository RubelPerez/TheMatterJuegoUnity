using UnityEngine;
using System.Collections;

public class MenuDeNivelTres : MonoBehaviour {

    private bool JugadorEnZona;
    public string Menu;
    private int guardar;
    PuntajeControllerTres record;
    // Use this for initialization
    void Start()
    {
        JugadorEnZona = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (JugadorEnZona)
        {
            SuenaMusica();
            record = GameObject.Find("textoPunto").GetComponent<PuntajeControllerTres>();
            PlayerPrefs.SetInt("scoretres", record.puntaje2);
            Application.LoadLevel(Menu);

        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Player")
        {

            JugadorEnZona = true;

        }

    }

    public void SuenaMusica()
    {

        AudioClip clip;

        gameObject.GetComponent<AudioSource>().playOnAwake = false;
        clip = gameObject.GetComponent<AudioSource>().clip;
        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));
        Destroy(GetComponent<Collider2D>());
    }
}
