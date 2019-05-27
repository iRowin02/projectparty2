using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer volumeMixer;

    public void ToMainMenu()
    {
      SceneManager.LoadScene("Start Screen");
    }
    public void SetVolume (float volume)
    {
        volumeMixer.SetFloat("Volume", volume);
    }
}
