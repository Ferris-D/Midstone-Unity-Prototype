using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public int playerHealth;
    public bool isHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isHit)
        {
            playerHealth -= 10;
            if(playerHealth <= 0)
            {
                Debug.Log("Player has Died");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            isHit = false;
        }
    }
}
