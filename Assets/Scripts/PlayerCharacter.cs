using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    //Variables go first
    public int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;
    public double experience = 0;
    public double exptolevelup = 50;
    public double EnemyHealth;
    public int enemylevel;
    private bool isPlayerTurn = true;
    private bool isGameOver = false;
    //[SerializeField] private Combat combat;
    //[SerializeField] private Enemy enemy;
    //[SerializeField] private GameObject zahenemy;

    // Methods will go  underneath here
    // we need our player character to attack when you hit the space bar

    public TMP_Text combatLog;
   // public TMP_Text statsUpdate;

    // Start is called before the first frame update
    private void Start()
    {
        combatLog.text = "Ready, Fight!!";

        Newenemy();
        Debug.Log("A new challenger appears!");
        //enemylevel = Random.Range(1, 6);
        //EnemyHealth = 5 + 5 * level;
        //collision = GetComponent<GameObject>();
    }


    // Update is called once per frame
    public void Update()
    {
        // if the player presses the spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ..... do a thing
            Debug.Log("Space bar has been destroyed!");
            Debug.Log("Attack: " + attack);
            combatLog.text = "Attack: " + Mathf.Round((float)attack * 100) / 100;
            takeDamage();
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
            combatLog.text = "Press 'R' to restart";
            Playerwins();

        }

        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            return;
        }





    }



    public void takeDamage()
    {
        EnemyHealth -= attack;
        Debug.Log("Enemy took " + attack + " damage");
        combatLog.text = "Player attacks for " + attack + " damage";
        if (EnemyHealth <= 0)
        {
            OnDeath();
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

    private void Newenemy()
    {
        enemylevel = Random.Range(1, 6);
        EnemyHealth = 5 + 5 * enemylevel;
        Debug.Log("A new challenger appears!");
    }


    public void OnDeath()
    {
        Newenemy();
        Debug.Log("Enemie has been slan");
        combatLog.text = "\nEnemy defeated! combat over";
        experience += enemylevel * 10;
        Debug.Log("Player gains " +  experience);
        //RandomPos.x = Random.Range(-3, 4);
        //RandomPos.y = Random.Range(-3, 4);
        //RandomPos.z = 0;
        //Instantiate(Transform.transform,RandomPos,Quaternion.identity);
    }

   //private void statsUpdate()
   // {
   //     statsUpdate.text = 
   // }
   // public void PlayerAttack()
   // {

    //    if (EnemyHealth <= 0)
    //    {
   //         combatLog.text = "\nEnemy defeated! combat over";
    //        IncreaseExperience();

   //     }
   //     else
   //     {
   //        combatLog.text = "\nEnemy health " + EnemyHealth;
    //    }
   // }




 //   public void IncreaseExperience()
  //  {
  //      experience += enemylevel * 10;
  //  }
 //   private void PlayerDeath()
  //  {

  //  }

    public void Playerwins()
    {
        combatLog.text += "\nPlayer Wins!!!!!!!!!!!!!!!!!!!!!!!";
        isGameOver = true;
        combatLog.text += "\nGame Over Press 'R' to Restart!";
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

