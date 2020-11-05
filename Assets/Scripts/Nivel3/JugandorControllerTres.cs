using UnityEngine;
using System.Collections;

public class JugandorControllerTres : MonoBehaviour {
    #region variables
    public float salto = 5f;
    public float velocidad = 5f;
    public float puntoresta = 30f;
    public int puntosLess = -1;
    //chekar doble salto
    public Transform pisoCheck;
    public float pisoCheckRadio = 0.05f;
    public LayerMask pisoLayer;

    private bool enPiso;
    private bool dobleSalto;
    private Animator animacion;
    #endregion

    private bool derecha = false;
    private bool izquierda = false;
    private bool saltar = false;
    // Use this for initialization
    void Start()
    {
        animacion = GetComponent<Animator>();
        StartCoroutine("Restamelo");
    }
    void FixedUpdate()
    {
        enPiso = Physics2D.OverlapCircle(pisoCheck.position, pisoCheckRadio, pisoLayer);
    }
    // Update is called once per frame
    void Update()
    {
        #region salto
        dobleSalto = true;
        animacion.SetBool("isJumping", true);
        if (enPiso)
        {



            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, salto);
            animacion.SetBool("isJumping", false);
            SuenaMusica();

        }

        #endregion

        #region movimiento/animacion 
        if (Input.GetKey(KeyCode.D) || derecha)
        {

              GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad,GetComponent<Rigidbody2D>().velocity.y);
           
        }
        if (Input.GetKey(KeyCode.S) || izquierda)
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidad, GetComponent<Rigidbody2D>().velocity.y);
            
        }
        

        animacion.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        #endregion

    }
    public void SuenaMusica()
    {

        AudioClip clip;

        gameObject.GetComponent<AudioSource>().playOnAwake = false;
        clip = gameObject.GetComponent<AudioSource>().clip;
        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));
    }
    public IEnumerator Restamelo()
    {


        yield return new WaitForSeconds(puntoresta);
        PuntajeControllerTres.AgregarPuntos(puntosLess);
        StartCoroutine("Restamelo");
    }
    public void Reiniciar()
    {



    }

    public void MoverDerecha()
    {
        derecha = true;
        izquierda = false;
    }

    public void MoverIzqda()
    {

        izquierda = true;
        derecha = false;
    }

    public void Saltar()
    {
        saltar = true;
    }
    public void DetenerDerecha()
    {
        derecha = false;


    }
    public void DetenerIzquierda()
    {
        izquierda = false;

    }
    public void DetenerSaltar() { saltar = false; }
}

