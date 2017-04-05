using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class PauseGame : MonoBehaviour
{
    public Transform canvas;
    public Transform Player;





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void resumeGame()
    {
        Pause();
    }
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            //Player.GetComponent<ThirdPersonController>().enabled = false;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            //Player.GetComponent<ThirdPersonController>().enabled = true;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
}