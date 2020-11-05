using UnityEngine;
using System.Collections;

public class LimitesTotales : MonoBehaviour {


    private LevelController level;
    private JugandorController jugador;
    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<LevelController>();
        jugador = FindObjectOfType<JugandorController>();
    }

    // Update is called once per frame
    void Update () {

    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            level.RespawnPlayer();

        }
    }
}
