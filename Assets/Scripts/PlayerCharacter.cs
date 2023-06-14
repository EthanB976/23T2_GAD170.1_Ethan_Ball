using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    //Variables go first
    [SerializeField] private int attack     =  10;
    [SerializeField] private int health     = 100;
    [SerializeField] private int level      =   1;
    [SerializeField] private int experience =   0;

    // Methods will go  underneath here
    // we need our player character to attack when you hit the space bar

    // Start is called before the first frame update
    private void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
        experience = 0;
        StartTheGameAtLevel1();
    }

    // Update is called once per frame
    private void Update()
    {
        // if the player presses the spacebar
        if (Input.GetKeyDown(KeyCode.Space)) ;
        {
            // ..... do a thing
            Debug.Log("Space bar has been destroyed!");
            level++;
        }
    }

    private void StartTheGameAtLevel1()
    {
        attack = 10;
        health = 100;
        level = 1;
        experience = 0;
    }
}
