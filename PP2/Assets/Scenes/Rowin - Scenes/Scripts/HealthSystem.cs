using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int healthAmount;
    public int heartAmount;

    public Image[] health;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < health.Length; i++)
        {
            //
            if(healthAmount > heartAmount)
            {
                healthAmount = heartAmount;
            }
            //
            if (i < healthAmount)
            {
                health[i].sprite = fullHeart;
            }
            else
            {
                health[i].sprite = emptyHeart;
            }
            //
            if (i < heartAmount)
            {
                health[i].enabled = true;
            }
            else
            {
                health[i].enabled = false;
            }
            //
        }
    }
}
