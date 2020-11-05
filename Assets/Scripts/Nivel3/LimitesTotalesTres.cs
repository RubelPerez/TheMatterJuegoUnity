using UnityEngine;
using System.Collections;

public class LimitesTotalesTres : MonoBehaviour {

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
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            level.RespawnPlayer();

        }
    }
}
