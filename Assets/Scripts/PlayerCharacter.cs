using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    //Variables go first
    [SerializeField] private double attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;
    [SerializeField] private int experience = 0;
    [SerializeField] private double exptolevelup = 50;
    [SerializeField] private GameObject zahenemy;

    // Methods will go  underneath here
    // we need our player character to attack when you hit the space bar

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        // if the player presses the spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ..... do a thing
            Debug.Log("Space bar has been destroyed!");
            //LevelUp();

        }
        if (experience >= exptolevelup)
        {
            LevelUp();
        }
        if (level == 5)
        {
            //player wins
            Debug.Log("You Win!!!!!!!!");
        }
    }

    private void LevelUp()
    {
        attack *= 1.225;
        level++;
        exptolevelup *= 1.75;
        Debug.Log("Level up");
        Debug.Log("Attack: " + Mathf.Round((float)attack * 100) / 100);
    }
    /**
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
}

