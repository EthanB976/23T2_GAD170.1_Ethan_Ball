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

    // Start is called before the first frame update
    private void Start()
    {
        attack = 10;
        health = 100;
        level = 0;
        experience = 0;
        StartTheGameAtLevel1();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void StartTheGameAtLevel1()
    {
        attack = 10;
        health = 100;
        level = 0;
        experience = 0;
    }
}
