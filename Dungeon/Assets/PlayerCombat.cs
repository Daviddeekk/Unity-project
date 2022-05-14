using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public static int attackDamage = 20;
    public Animator animator;
    public int cooldown = 100;
    public double rychlost = 1;
    public static int zabitychNepratel = 0;


    public Text AS;
    public Text Damage;
    // Update is called once per frame
    void Update()
    {
       
        Damage.text = attackDamage.ToString();
        if(cooldown > 0){
            cooldown = cooldown - 1;
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {}
        else  {
            if(cooldown == 0)
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                 Attack();
                 cooldown =100;
            }}}   
           aspedd();
    }
    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies){
           // Debug.Log("We hit " + attackDamage +"  "+enemy.name+ " ");
           Debug.Log( enemy.GetComponent<enemies>());
            //if(enemy.GetType() == typeof(enemies)){
               // Debug.Log("asdflkafd");

                enemy.GetComponent<enemies>().getDamage(attackDamage);
                //enemies.getDamage(attackDamage);
               
        //}
        }
       

 }
 void aspedd(){

     
      AS.text = rychlost.ToString();
 }
 
    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
    
}
