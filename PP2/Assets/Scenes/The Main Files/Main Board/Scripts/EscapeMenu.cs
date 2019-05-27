using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour

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
              Time.timeScale = 0;
              canvasEscape.SetActive(true);
            }
            else
            {
              Time.timeScale = 1;
              canvasEscape.SetActive(false);
            }
     }
  }
         public void ResumeGame()
        {
        Time.timeScale = 1;
        canvasEscape.SetActive(false);
        }
        public void Back()
  {
      SceneManager.LoadScene("Start Screen");
  }
  public void EscapeSettings()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
