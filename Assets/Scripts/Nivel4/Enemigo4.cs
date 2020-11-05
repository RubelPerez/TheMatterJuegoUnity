using UnityEngine;
using System.Collections;

public class Enemigo4 : MonoBehaviour {

    public float velocidadMovimiento = 2;
    public bool moverDerecha;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moverDerecha)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);

        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Derecha")
        {
            moverDerecha = false;

        }
        else if (col.name == "Izquierda")
        {
            Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x);
            moverDerecha = true;
        }

    }
}
