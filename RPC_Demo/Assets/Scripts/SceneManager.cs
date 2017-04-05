using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	void OnTriggerEnter(Collider ChangeScene) {
		if(ChangeScene.gameObject.CompareTag("Player"))
		{
			Application.LoadLevel ("level02");
		}
	}
}

