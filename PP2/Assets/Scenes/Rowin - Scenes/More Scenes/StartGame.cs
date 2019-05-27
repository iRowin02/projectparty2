using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
  public GameObject canvasEscape;
  public bool gamePaused;

  public void Update()
  {
    if (Input.GetButtonDown("Cancel"))
    {
      gamePaused = !gamePaused;

            if(gamePaused == true)
            {
              print("OK");
            }
            else
            {
              print("NO");
            }
    }
  }
  public void StartTheGame()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  public void Back()
  {
      SceneManager.LoadScene("Start Screen");
  }
  public void QuitTheGame()
  {
      Application.Quit();
  }
  public void Settings()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
  }
}
