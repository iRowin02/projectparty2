using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomScene : MonoBehaviour
{
    public int minScene;
    public int maxScene;

    public void RandomSceneLoader()
    {       
        int scene = Random.Range(minScene, maxScene);
        SceneManager.LoadScene(scene);
    } 
}
