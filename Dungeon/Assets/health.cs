using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{   
    public Animator animator;
    public static int armor = 1;
    public static int maxHealth = 100;
    public static int currentHealth;
    public Healthbar healthbar;
    private int cooldown = 100;
    private int die = 1900;
    public int nahodne;
    
    public int regen = 1;

    public Text healthcurrent;
    public Text armory;
   
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        healthcurrent.text = currentHealth.ToString();
        armory.text = armor.ToString();
        Animator anim = GetComponent<Animator>();
            anim.SetBool("Die",false);
    }

    // Update is called once per frame
    void Update()
    {


        if (maxHealth == currentHealth){
        }
        else
        {
            cooldown = cooldown - 1;
            if(cooldown == 0){
                currentHealth = currentHealth + regen;
                cooldown = 100;
            }

        }
         if(currentHealth <= 0){
             Die();
             die = die -1;
         }
         healthcurrent.text = currentHealth.ToString();
    }
   public  void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
     private void OnTriggerEnter2D(Collider2D other)
    {
       
            if(other.gameObject.CompareTag("Enemy"))
            {
                if(Input.GetKey(KeyCode.LeftShift)){
                   
                    nahodne = Random.Range(1, 4); 
                    //Debug.Log(nahodne);
                    if(nahodne == 1){
                   currentHealth = currentHealth - enemies.damages + armor;
                    }
                    else{

                    }

                }
                else{
                currentHealth = currentHealth - enemies.damages  + armor;
                //Debug.Log("damage");
                }
            }
         
    }
    private void Die(){

       
            Animator anim = GetComponent<Animator>();
            
            anim.SetBool("Die",true);
           
            if(die == 0){

            
            SceneManager.LoadScene("DieScene");
            }
        

    }
}
