﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    private Vector3 offset = new Vector3(0,5,-7);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}