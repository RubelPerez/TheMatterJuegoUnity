using UnityEngine;
using System.Collections;

public class SpikesItem : MonoBehaviour
{
    private LevelController level;
    private JugandorController jugador;
    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<LevelController>();
        jugador = FindObjectOfType<JugandorController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col2)
    {
        if (col2.name == "Player")
        {
            level.RespawnPlayer();
            
        }
        jugador.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jugador.GetComponent<Rigidbody2D>().velocity.y);
        jugador.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jugador.GetComponent<Rigidbody2D>().velocity.y);

    }
 
}