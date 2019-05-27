using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
  public GameObject canvasEscape;
  public bool gamePaused;

  public void FixedUpdate()
  {
    if (Input.GetButtonDown("Cancel"))
    {
      print("Test1");

        if (gamePaused == false)
          {
            Time.timeScale = 0;
            canvasEscape.SetActive(true);
            gamePaused = true;
          }
          
            if (gamePaused == true)
              {
                Time.timeScale = 1;
                canvasEscape.SetActive(false);
                gamePaused = false;
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
