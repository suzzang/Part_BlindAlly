﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EndingExplainBefore : MonoBehaviour, IPointerClickHandler
{
    public EndingExplain ex;
    public void OnPointerClick(PointerEventData eventData)
    {
        ex.is_next = 0;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
