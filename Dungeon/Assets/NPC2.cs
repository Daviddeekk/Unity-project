using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : MonoBehaviour
{
    public static int coinss;
    public static bool permission = false;
   public DialogueTrigger trigger;
   private void OnCollisionEnter2D(Collision2D collision){
   
        /*if(collision.gameObject.CompareTag("Player")==true){
           
            trigger.StartDialogue();
        }
*/
         if(collision.gameObject.CompareTag("Player")==true){
             trigger.StartDialogue();
           
           
        }
        
   }

   void Update(){
    coinss = playeMove.coins;

   }
}

