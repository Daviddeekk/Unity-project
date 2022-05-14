using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destroy();
    }
    void destroy(){
        if(PlayerCombat.zabitychNepratel == 3)
        {
            Destroy(gameObject);
            Debug.Log("walls out");
        }
    }
}
