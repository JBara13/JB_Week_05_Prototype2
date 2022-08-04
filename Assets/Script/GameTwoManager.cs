using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTwoManager : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

    public int P1Life;
    public int P2Life;

    public GameObject p1Wins;
    public GameObject p2Wins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (P1Life >= P2Life)
        {
            p1Wins.SetActive(true);
        }

        if (P2Life >= P1Life)
        {
            p2Wins.SetActive(true);
        }
    }
}
