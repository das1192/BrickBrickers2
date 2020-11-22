using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {



	public float paddlepos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddleMove = new Vector3 (this.transform.position.x,this.transform.position.y,0f);

		paddlepos= Input.mousePosition.x / Screen.width * 16;
		paddleMove.x = Mathf.Clamp( paddlepos,1.45f,14.62f);
		this.transform.position = paddleMove;
	}
}
