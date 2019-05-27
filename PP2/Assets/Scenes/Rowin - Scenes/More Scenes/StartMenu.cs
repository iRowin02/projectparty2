﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
  public void StartTheGame()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  public void Settings()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
  }
  public void QuitTheGame()
  {
      Application.Quit();
  }
}
