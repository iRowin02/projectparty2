using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomScene : MonoBehaviour
{
    public int minScene;
    public int maxScene;

    public void Start()
    {
        //minScene = 3;
        //maxScene = 4;
    }

    public void RandomSceneLoader()
    {       
        //int scene = Random.Range(minScene, maxScene);
        SceneManager.LoadScene(3);
    } 
}
