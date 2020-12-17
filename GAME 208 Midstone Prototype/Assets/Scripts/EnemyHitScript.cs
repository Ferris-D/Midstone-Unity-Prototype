using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitScript : MonoBehaviour
{
	//Used to check if the target has been hit
	public bool isHit = false;

	// Enemy Health
	public int enemyHealth;

	// Start is called before the first frame update
	void Start()
    {
		enemyHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
		//If the target is hit
		if (isHit == true)
		{
			enemyHealth -= 10;

			// If health is zero or below delete itself
			if (enemyHealth <= 0)
            {
				gameObject.GetComponent
				<EnemyController>().Die();
				//Debug.Log("Enemy Destroyed");

				//Destroy(gameObject);
			}

			//Debug.Log("Enemy Hit");
			isHit = false;
		}

	}
}
