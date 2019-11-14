﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MovingObject
{
	public int playerDamage;

	private Animator animator; 
	private Transform target;
	private bool skipMove;

    // Start is called before the first frame update
    protected override void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void AttemptMove <T> (int xDir, int yDir)
	{
		if(skipMove)
		{
			skipMove = false;
			return;
		}

		base.AttemptMove <T> (xDir, yDir);
	}

	public void MoveEnemy()
	{
		int xDir = 0;
		int yDir = 0;

		if (Mathf.Abs(target.position.x - transform.position.x) - float.Epsilon)
	}
}
