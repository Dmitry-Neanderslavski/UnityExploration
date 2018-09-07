using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectGem : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionText;
	public GameObject EnlargedCursor;
	public GameObject TheGem;
	public AudioSource CollectSound;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}
	void OnMouseOver(){
		if (TheDistance <= 3) {
			ActionText.SetActive (true);
			EnlargedCursor.SetActive (true);
		}
		else {
			ActionText.SetActive (false);
			EnlargedCursor.SetActive (false);
		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3) {
				CollectSound.Play ();
				TheGem.SetActive (false);
				ActionText.SetActive(false);
				EnlargedCursor.SetActive(false);
				}
			}
		}
	void OnMouseExit () {
		ActionText.SetActive (false);
		EnlargedCursor.SetActive (false);
	}
}