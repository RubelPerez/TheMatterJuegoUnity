using UnityEngine;
using System.Collections;

public class CheckPointTres : MonoBehaviour {

    public levelControllerTres level;
    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<levelControllerTres>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            level.currentCheckPoint = gameObject;
            SuenaMusica();
        }
    }
    public void SuenaMusica()
    {

        AudioClip clip;

        gameObject.GetComponent<AudioSource>().playOnAwake = false;
        clip = gameObject.GetComponent<AudioSource>().clip;
        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));
        Destroy(GetComponent<Collider2D>());
    }
}
