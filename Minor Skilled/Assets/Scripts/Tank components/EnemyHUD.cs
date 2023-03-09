﻿using System;
using TMPro;
using UnityEngine;

public class EnemyHUD : BaseHUDManager
{
    [SerializeField] private TextMeshProUGUI enemyName;
    private Transform playerTransform;
    [SerializeField] private GameObject canvas;    
    
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        canvas.transform.LookAt(playerTransform.position);
    }

    public override void UpdateName(string name)
    {
        enemyName.SetText(name);
    }

    public override void UpdateSpeed(float speed)
    {
        
    }
}