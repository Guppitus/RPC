using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	void OnTriggerEnter(Collider ChangeScene) {
		if(ChangeScene.gameObject.CompareTag("Player"))
		{
            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "level02")
            {
                Application.LoadLevel("level02");
            }
        }
	}
}

