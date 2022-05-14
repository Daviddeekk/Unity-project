using System.Collections;

using UnityEngine;

public class playeMove : MonoBehaviour
{
    // Start is called before the first frame update
  public static float DEFAULT_MOVESPEED = 300f;
   public Animator animator;
   public float currentMoveSpeed =300f;
   public Rigidbody2D rb;
   public static int coins =0;
   public static bool permission;
  // float horizontalMove = 0f;
    Vector2 movement;

    void Update()
    {
     if(DialogueManager.isActive == true){
       movement.x = 0;
       movement.y = 0;
        animator.SetFloat("Speed",Mathf.Abs(movement.y + movement.x + movement.x));
      return;
     }
        
      movement.x =  Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Speed",Mathf.Abs(movement.y + movement.x + movement.x));

      

    }
 
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * currentMoveSpeed * Time.fixedDeltaTime);

        if (movement.x > 0)
        {
          gameObject.transform.localScale = new Vector3(-94, 110, 1);
        

        }
        if (movement.x < 0)
        {
          gameObject.transform.localScale = new Vector3(94, 110, 1);
        
 
        }
        if(Input.GetKey(KeyCode.LeftShift)){

          currentMoveSpeed = 150f;

        }else{
          currentMoveSpeed = DEFAULT_MOVESPEED;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
     
      if(other.gameObject.CompareTag("Coin")){
        
        Destroy(other.gameObject);
         coins = coins+1;
         Debug.Log("coinssnss");
        
     }

     

     if(other.gameObject.CompareTag("NPC")&& coins ==3)
     {
       coins = coins - 3;
     }
      

    }
       

    
   
}
