using UnityEngine;
using System.Collections;

public class JugandorController4 : MonoBehaviour
{
    #region variables
    public float salto = 5f;
    public float velocidad = 5f;
    public float puntoresta = 30f;
    public int puntosLess = -1;
    //chekar doble salto
    public Transform pisoCheck;
    public float pisoCheckRadio = 0.03f;
    public LayerMask pisoLayer;
    private float Muevetecontrolado;

    private bool derecha = false;
    private bool izquierda = false;
    private bool saltar = false;

    private bool enPiso;
    private bool dobleSalto;
    private Animator animacion;
    #endregion
    // Use this for initialization
    void Start()
    {

        animacion = GetComponent<Animator>();
        animacion.SetBool("isJumping", true);
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
        Muevetecontrolado = 0;
        #region movimiento/animacion 
        if (derecha || Input.GetKey(KeyCode.D))
        {


            //  GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad,GetComponent<Rigidbody2D>().velocity.y);
            Muevetecontrolado = velocidad;

            izquierda = false;

        }
        if (izquierda || Input.GetKey(KeyCode.S))
        {


            //GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidad, GetComponent<Rigidbody2D>().velocity.y);
            Muevetecontrolado = -velocidad;
            derecha = false;

        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(Muevetecontrolado, GetComponent<Rigidbody2D>().velocity.y);


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
        PuntajeController4.AgregarPuntos(puntosLess);
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
