using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public int BlockHp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (BlockHp <= 0)
        {
            Destroy(this.gameObject);
            Manager.AllCount -= 1;
       }
	}
}
