using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Combat : MonoBehaviour
{

    [SerializeField] PlayerCharacter player;
    [SerializeField] Enemy enemy;
    private bool isPlayerTurn = true;
    private bool isGameOver = false;



    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    public void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPlayerTurn)
                PlayerAttack();
            
            //Player attacks and does damage to enemy

        }



    }
    public void PlayerAttack()
    {
        enemy.EnemyHealth -= player.attack;
        player.combatLog.text = "Player attacks for " + player.attack + " damage";

        if (enemy.EnemyHealth <= 0)
        {
            player.combatLog.text = "\nEnemy defeated! combat over";
            IncreaseExperience();

        }
        else
        {
            player.combatLog.text = "\nEnemy health " + enemy.EnemyHealth;
        }
    }

   
    

    public void IncreaseExperience()
    {
        player.experience += enemy.level * 10;
    }

    private void PlayerDeath()
    {

    }

    public void Playerwins()
    {
        player.combatLog.text += "\nPlayer Wins!!!!!!!!!!!!!!!!!!!!!!!";
        isGameOver = true;
        player.combatLog.text += "\nGame Over Press 'R' to Restart!";
    }








}







