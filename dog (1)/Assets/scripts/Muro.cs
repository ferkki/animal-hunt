﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Gamemanage.compartido.monedas == Gamemanage.compartido.monedasNecesariasParaElMuro)
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
	}
}
