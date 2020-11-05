using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TenerTres : MonoBehaviour {



 public Text txtnieve;


    // Use this for initialization
    void Start()
    {
        txtnieve = gameObject.GetComponent<Text>();


    }
    void Update()
    {

        txtnieve.text = PlayerPrefs.GetInt("scoretres").ToString();


    }


    // Update is called once per frame

}