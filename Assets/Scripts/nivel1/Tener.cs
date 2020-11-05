using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Tener : MonoBehaviour
{
    public Text txt;
   

    // Use this for initialization
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
       

    }
    void Update() {

        txt.text = PlayerPrefs.GetInt("score").ToString();
     

    }
    

    // Update is called once per frame

}