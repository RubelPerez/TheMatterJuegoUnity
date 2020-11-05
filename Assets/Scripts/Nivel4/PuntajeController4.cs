using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PuntajeController4 : MonoBehaviour {
    public static int puntaje;
    public int puntaje2;
    Text texto;
    // Use this for initialization
    void Start()
    {
        texto = GetComponent<Text>();
        puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (puntaje < 0)
            puntaje = 0;
        texto.text = "" + puntaje;
        puntaje2 = puntaje;
    }

    public static void AgregarPuntos(int puntosAgregar)
    {
        puntaje += puntosAgregar;

    }

    public static void Reset()
    {
        puntaje = 0;
    }
}
