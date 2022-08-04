using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonMashController : MonoBehaviour
{

    public int numberOfKeyPresses = 0;

    public Transform player;

    public KeyCode keyOne;
    public KeyCode keyTwo;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyOne))
        {
            numberOfKeyPresses++;
            scoreText.text = numberOfKeyPresses.ToString("0");
        }

        if (Input.GetKeyDown(keyTwo))
        {
            numberOfKeyPresses++;
            scoreText.text = numberOfKeyPresses.ToString("0");
        }

    }

}
