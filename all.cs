using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class all : MonoBehaviour
{
    public GameObject[] Players;
    [SerializeField]

    GameObject currentPlayer;  

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<realPlayer>().enabled = false;
        }
        currentPlayer = Players[0];
    }

    public void changePlayer(GameObject player)
    {
        currentPlayer.GetComponent<realPlayer>().enabled = false;
        currentPlayer = player;
    }

}
