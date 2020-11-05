using UnityEngine;
using System.Collections;

public class OptimizacionParticulas : MonoBehaviour {
    private ParticleSystem particulas;
	// Use this for initialization
	void Start () {
        particulas = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (particulas.isPlaying) {
            return;
        }
        Destroy(gameObject);
	}
}
