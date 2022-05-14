using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    public static int damages = 5;
    public int health = 100;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    public void getDamage(int damage){
        health = health - damage;
        Debug.Log(health);
       
    }
     private void dead()
    {
        if(health  <= 0)
        {
            Destroy(gameObject);
            Debug.Log("destroyed");
            PlayerCombat.zabitychNepratel = PlayerCombat.zabitychNepratel + 1;
        }

    }
    // Update is called once per frame
    void Update()
    {
       
         dead();
    }


}
