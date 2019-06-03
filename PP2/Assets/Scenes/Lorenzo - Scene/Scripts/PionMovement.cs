using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PionMovement : MonoBehaviour
{
    public int min;
    public int max;
    public int turnPlayers;
    public int randomNumber;
    public GameObject[] players;
    public bool turnOver;
    public float timeTill;
    public int minScene;
    public int maxScene;

    public void Start()
    {
        //Random Number Start
        min = 1;
        max = 7;
        randomNumber = Random.Range(min, max);
        players[turnPlayers].GetComponent<Player1>().waypointsToGo = randomNumber;

        //Player Movement off
        for (int i = 0; i < players.Length; i++)
        {
            players[i].GetComponent<Player1>().enabled = false;
        }

        //First player
        turnPlayers = 0;
        players[turnPlayers].GetComponent<Player1>().enabled = true;

        //Minigame Scene
        minScene = 3;
        maxScene = 4;

        //Time To minigame
        timeTill = 10f;
    }
    public void Update()
    {
        //Input Turn
        //if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>().slot == false)
        //{
            if (Input.GetButtonDown("Interact"))
            {
                PlayerTurn(turnPlayers);
                randomNumber = Random.Range(min, max);
                players[turnPlayers].GetComponent<Player1>().waypointsToGo = randomNumber;
                players[turnPlayers].GetComponent<Player1>().speed = 10f;
            }
        //}
        if (turnOver == true)
        {
            timeTill -= Time.deltaTime;
            if (timeTill < 0)
            {
                int scene = Random.Range(minScene, maxScene);
                SceneManager.LoadScene(scene);
                turnPlayers = 0;
            }
        }
    }
    public void PlayerTurn(int turn)
    {
        players[turn].GetComponent<Player1>().enabled = true;
    }
    public void Check()
    {
        players[turnPlayers].GetComponent<Player1>().enabled = false;
        if (turnPlayers >= players.Length-1)
        {
            turnOver = true;
        }
        else
        {
            turnPlayers++;
        }      
    }
}
