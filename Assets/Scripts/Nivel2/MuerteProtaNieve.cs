using UnityEngine;
using System.Collections;

public class MuerteProtaNieve : MonoBehaviour
{

    private levelControllerNieve level;
    private JugandorControllerNieve jugador;
    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<levelControllerNieve>();
        jugador = FindObjectOfType<JugandorControllerNieve>();
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
    }
}
