using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update
private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Win");
        Debug.Log("asůdklfljfj");
    }
}
