using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TenerNieve : MonoBehaviour {



 public Text txtnieve;


    // Use this for initialization
    void Start()
    {
        txtnieve = gameObject.GetComponent<Text>();


    }
    void Update()
    {

        txtnieve.text = PlayerPrefs.GetInt("scorenieve").ToString();


    }


    // Update is called once per frame

}