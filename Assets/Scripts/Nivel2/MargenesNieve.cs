﻿using UnityEngine;
using System.Collections;

public class MargenesNieve : MonoBehaviour {
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
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            level.RespawnPlayer();

        }
        jugador.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jugador.GetComponent<Rigidbody2D>().velocity.y);

        jugador.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jugador.GetComponent<Rigidbody2D>().velocity.y);

        AudioClip clip;
        if (col.gameObject.name == "Player")
        {
            gameObject.GetComponent<AudioSource>().playOnAwake = false;
            clip = gameObject.GetComponent<AudioSource>().clip;
            AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));


        }
    }
}