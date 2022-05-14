using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefense : MonoBehaviour
{
    // Start is called before the first frame update
  
    public Animator animator;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            Defense();


        }
    }
    public void Defense()
    {
        animator.SetTrigger("Defense");
        
    }

  
}
