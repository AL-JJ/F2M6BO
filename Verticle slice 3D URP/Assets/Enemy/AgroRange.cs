using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgroRange : MonoBehaviour
{
	public string Tag = "Player";
	public float _AgroRange =2f;

	void Start()
	{
		InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}

	//check if player is in range
	void UpdateTarget()
	{
		GameObject player = GameObject.FindGameObjectWithTag(Tag);
			float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
			if (distanceToPlayer <= _AgroRange)
			{
				GetComponent<StateManager>().ChangeBehavoir("Found");
			}

	}

	//show the agro range (Def only)
	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, _AgroRange);
	}
}

