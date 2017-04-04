using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	Transform player;                 // Reference to the player's position.
	//PlayerHealth playerHealth;      // Reference to the player's health.
	//EnemyHealth enemyHealth;        // Reference to this enemy's health.

	NavMeshAgent nav;                 // Reference to the nav mesh agent.
	float maximumLookDistance = 25;
	Animator anim;


	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform;
//		playerHealth = player.GetComponent <PlayerHealth> ();
//		enemyHealth = GetComponent <EnemyHealth> ();
		anim = GetComponent<Animator>();
		nav = GetComponent <NavMeshAgent> ();



	void Update ()
	{
		var difference = Vector3.Distance(player.position, transform.position);

		if(difference <= maximumLookDistance)
		{	
			nav.enabled = true;
			anim.SetBool ("PlayerClose", true);
			// ... set the destination of the nav mesh agent to the player.
			nav.SetDestination(player.position);
		}
		// Otherwise...
		else
		{
			// ... disable the nav mesh agent.
			nav.enabled = false;
			anim.SetBool ("PlayerClose", false);
		}
	} 
}