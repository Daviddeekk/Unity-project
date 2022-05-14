using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItems : MonoBehaviour
{
    private int rng;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCombat.attackDamage = 20;
         playeMove.DEFAULT_MOVESPEED = 250;
         health.maxHealth = 100;
         health.currentHealth = 100;
         health.armor = 1; 
    }
    public void generuj(){

         rng = Random.Range(1, 4); 
         Debug.Log(rng);
         if(rng == 1){
             health.maxHealth = health.maxHealth + 15;
             health.currentHealth = health.currentHealth + 15;
         
         }
         if(rng == 2){

             PlayerCombat.attackDamage = PlayerCombat.attackDamage + 5;
         }
         if(rng == 3){
             playeMove.DEFAULT_MOVESPEED = playeMove.DEFAULT_MOVESPEED + 100;
   
         }
         if(rng == 4){
             health.armor = health.armor + 1;
         }

    }
     private void OnTriggerEnter2D(Collider2D other)
    {
     
      if(other.gameObject.CompareTag("Player")){
        generuj();
        Destroy(gameObject);
         
         Debug.Log("coinssnss");
        
     }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
