using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Init(bool isRightPaddle) {

        if (isRightPaddle) {
            transform.position = new Vector2(GameManager.topRight.x - transform.localScale.x, 0);
        }
        else {
            transform.position = new Vector2(GameManager.bottomLeft.x + transform.localScale.x, 0);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
