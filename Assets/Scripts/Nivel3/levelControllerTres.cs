using UnityEngine;
using System.Collections;

public class levelControllerTres : MonoBehaviour {


		// Use this for initialization
		public GameObject currentCheckPoint;
	private JugandorControllerTres player;
		public GameObject particulaMuerte;
		public GameObject particulaInicio;
		public float tiempoReinicio;
		void Start () {
		player = FindObjectOfType<JugandorControllerTres>();
		}

		// Update is called once per frame
		void Update () {

		}

		public void RespawnPlayer() {
			StartCoroutine("respawnPlayer");
			SuenaMusica();

		}

		public void SuenaMusica()
		{

			AudioClip clip;

			gameObject.GetComponent<AudioSource>().playOnAwake = false;
			clip = gameObject.GetComponent<AudioSource>().clip;
			AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));
		}
		public IEnumerator respawnPlayer() {
			Instantiate(particulaMuerte, player.transform.position, player.transform.rotation);
			player.enabled = false;
			player.GetComponent<Renderer>().enabled = false;
			yield return new WaitForSeconds(tiempoReinicio);
			player.transform.position = currentCheckPoint.transform.position;
			Instantiate(particulaInicio, player.transform.position, player.transform.rotation);
			player.enabled = true;
			player.GetComponent<Renderer>().enabled = true;

		}

	}
