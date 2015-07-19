using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour
{
    #region Public Member Variables
  //  public float Speed = 555.0f;
	public float BulletSpeed = 200f; 
	public float TargetLife =2f; 
    #endregion

    #region Private Member Variables
    private Rigidbody2D _Rigidbody = null;
	private float life; 
    #endregion

    #region Unity Methods
    private void Start() 
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
		_Rigidbody.AddForce (transform.up * BulletSpeed); 

		life = TargetLife; 
        // TO-DO: code this class
	}
		
    private	void Update () 
    {
		// TO-DO: code this class
		life -= Time.deltaTime; 
		if (life < 0)
			Destroy (gameObject); 
	}

    private void FixedUpdate()
    {
        // TO-DO: code this class
    }
    #endregion

	void OnCollisionEnter(Collision collision){
		Debug.Log("something has hit me");
	} 

//	void OnTriggerEnter2d(Collider2D collider)
//	{
//		Destroy (gameObject); 
//		Debug.Log ("Boom"); 
//	}

}
