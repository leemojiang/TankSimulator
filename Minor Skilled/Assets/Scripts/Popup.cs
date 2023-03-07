﻿using System.Collections;
using TMPro;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _contentText;
    [SerializeField] private float destroyDelay = 3f;
    
    private void Start()
    {
        Destroy(this.gameObject, destroyDelay);
    }

    public void UpdateContent(string content)
    {
        _contentText.SetText(content);
    }
}