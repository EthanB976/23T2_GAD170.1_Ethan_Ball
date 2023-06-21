using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] private double health;
    [SerializeField] private int level;
    //private GameObject collision;
    //private Vector3 RandomPos;

    public TMP_Text combatLog;
    

    // Start is called before the first frame update
    void Start()
    {
        Newenemy();
        //level = Random.Range(1, 6);
        //health = 5 + 5 * level;
        //collision = GetComponent<GameObject>();
    }


    // Update is called once per frame
    void Update()
    {
        //OnDeath();
    }

    private void OnDeath()
    {
        Newenemy();
        //RandomPos.x = Random.Range(-3, 4);
        //RandomPos.y = Random.Range(-3, 4);
        //RandomPos.z = 0;
        //Instantiate(Transform.transform,RandomPos,Quaternion.identity);
    }
    private void takeDamage(double damage)
    {
        health -= damage;
        Debug.Log("Enemy took " + damage + " damage");
        if (health <= 0)
        {
            OnDeath();
        }
    }
    private void Newenemy()
    {
        level = Random.Range(1, 6);
        health = 5 + 5 * level;
        Debug.Log("A new challenger appears!");
    }






}



