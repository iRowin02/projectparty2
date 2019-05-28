using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip buttonSound;
    public AudioSource musicSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoundOnClick(){
        musicSource.clip = buttonSound;
        musicSource.Play();
    }
}
