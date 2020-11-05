using UnityEngine;
using System.Collections;

public class SpikeItemTres : MonoBehaviour {


    private levelControllerTres level;
    private JugandorControllerTres jugador;
    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<levelControllerTres>();
        jugador = FindObjectOfType<JugandorControllerTres>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            level.RespawnPlayer();

        }
        jugador.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jugador.GetComponent<Rigidbody2D>().velocity.y);
        jugador.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jugador.GetComponent<Rigidbody2D>().velocity.y);

    }

}