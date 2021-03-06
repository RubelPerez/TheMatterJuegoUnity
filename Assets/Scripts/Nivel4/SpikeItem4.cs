﻿using UnityEngine;
using System.Collections;

public class SpikeItem4 : MonoBehaviour {


    private levelController4 level;
    private JugandorController4 jugador;
    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<levelController4>();
        jugador = FindObjectOfType<JugandorController4>();
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