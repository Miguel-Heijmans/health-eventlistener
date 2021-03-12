using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 100;
    public Text healthText;

    private void Awake() {
       var Delegate = GetComponent<Delegate>();
       Delegate.wasClicked += TakeDamage;
    }
    
    void TakeDamage(){
        int randInt = Random.Range(1, 21);
        health -= randInt;
        print("damage is: " + randInt);
    }

    void Update()
    {
        healthText.text = health.ToString();
        if(health <= 0){
            healthText.text = "0";
            print("Ik ben dood");
            Destroy(gameObject);
        }
    }
}
