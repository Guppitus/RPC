using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	Transform player;
	int damagePerHit = 5;
	Animator anim;

	void Start () {
		player = GameObject.FindWithTag("Player").transform;
		anim = GetComponent<Animator>();
	}
	
	void Update () {
	
	}
}
