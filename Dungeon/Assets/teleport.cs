using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
     public GameObject portal;
    private GameObject player;
    public static int coinss;
    public bool permission;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }



    
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"&& NPC.permission == true)
        {

    player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
         }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
