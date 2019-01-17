using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public float speed = 5f;
    float height;

    string input;
    public bool isRight;

	// Use this for initialization
	void Start () {
        height = transform.localScale.y;
	}

    public void Init(bool isRightPaddle) {

        isRight = isRightPaddle;

        if (isRightPaddle) {
            transform.position = new Vector2(GameManager.topRight.x - transform.localScale.x, 0);
            input = "PaddleRight";
        }
        else {
            transform.position = new Vector2(GameManager.bottomLeft.x + transform.localScale.x, 0);
            input = "PaddleLeft";
        }

        transform.name = input;

    }
	
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(0, Input.GetAxis(input) * Time.deltaTime * speed);

        if (transform.position.y < GameManager.bottomLeft.y + height / 2 && move.y < 0) {
            move = Vector2.zero;
        }

        if (transform.position.y > GameManager.topRight.y - height / 2 && move.y > 0) {
            move = Vector2.zero;
        }

        transform.Translate(move);

        
    }
}
