using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PlayerCharacter : MonoBehaviour
{
    //Variables go first
    public int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;
    public double experience = 0;
    public double exptolevelup = 50;
    [SerializeField] private Combat combat;
    //[SerializeField] private GameObject zahenemy;

    // Methods will go  underneath here
    // we need our player character to attack when you hit the space bar

    public TMP_Text combatLog;

    // Start is called before the first frame update
    private void Start()
    {
        combatLog.text = "Ready, Fight!!";
    }

    // Update is called once per frame
    private void Update()
    {
        // if the player presses the spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ..... do a thing
            Debug.Log("Space bar has been destroyed!");
            Debug.Log("Attack: " + Mathf.Round((float)attack * 100) / 100);
            combatLog.text = "Attack: " + Mathf.Round((float)attack * 100) / 100;

        }

        if (experience >= exptolevelup)
        {

           if (Input.GetKeyDown(KeyCode.L))
            {
                LevelUp();
                //LevelUp();
            }



        }

        if (level == 5)
        {
            //player wins
            combatLog.text = "You Win!!!";
            Debug.Log("You Win!!!!!!!!");
        }
    }

    private void LevelUp()
    {
        //When player levels up, increase attack, level, level exp, and diaplay on screen/in console
        attack = (int)(attack * 1.225);
        level++;
        exptolevelup *= 1.75;
        combatLog.text = "Level Up";
        Debug.Log("Level Up");
        
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

