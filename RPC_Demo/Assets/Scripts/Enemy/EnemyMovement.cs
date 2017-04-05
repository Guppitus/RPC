using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
	Transform player;                 // Reference to the player's position.
	//PlayerHealth playerHealth;      // Reference to the player's health.
	//EnemyHealth enemyHealth;        // Reference to this enemy's health.

	UnityEngine.AI.NavMeshAgent nav;                 // Reference to the nav mesh agent.
	float maximumLookDistance = 25;
	Animator anim;


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //		playerHealth = player.GetComponent <PlayerHealth> ();
        //		enemyHealth = GetComponent <EnemyHealth> ();
        anim = GetComponent<Animator>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }
	void Update ()
	{
		Scene scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();

		if (scene.name == "level01") {
			var difference = Vector3.Distance (player.position, transform.position);

			if (difference <= maximumLookDistance) {	
				anim.SetBool ("PlayerClose", true);
				nav.enabled = true;
				// ... set the destination of the nav mesh agent to the player.
				nav.SetDestination (player.position);
			} else {
				// ... disable the nav mesh agent.
				nav.enabled = false;
				anim.SetBool ("PlayerClose", false);
			}
		} else {
			if (scene.name == "level02") {
				anim.SetBool ("InCombat", true);
				nav.enabled = false;

			}
		}
	} 
}