﻿using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	// Update is called once per frame
	void Update () {
        //Debug.Log(player.position);
        if (GameObject.Find("Player") != null)
        {
            transform.position = player.position + offset;
        }
	}
}
