using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject TheGem;

	void Update () {
		transform.Rotate(0, RotateSpeed, 0, Space.World);
	}

	void OnTriggerEnter(Collider other)
	{
		CollectSound.Play();
		TheGem.SetActive(false);
	}
}