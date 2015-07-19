using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour
{
    #region Public Member Variables
    [Header("Audio Clips")]
    public AudioClip[] ExplosionClips;

    [Header("Properties")]
    public float   Speed  = 1.0f;
    public int     Health = 3;
    public Vector2 Direction = Vector2.up;
	public float MinTorque = -30f;
	public float MaxTorque = 60f;
	public float MinForce = 10f; 
	public float MaxForce = 20f;  

	public float MinX; 
	public float MaxX;
	public float MinY;
	public float MaxY; 
    #endregion

    #region Private Member Variables
    private Rigidbody2D _Rigidbody = null;
    #endregion

    #region Unity Methods    
	private void Start () 
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
		float magnitude = Random.Range (MinForce, MaxForce);
		float x = Random.Range (-1f, 1f);
		float y = Random.Range (-1f, 1f); 

		_Rigidbody.AddForce (magnitude * new Vector2 (x,y)); 

		float torque = Random.Range (MinTorque, MaxTorque); 
		_Rigidbody.AddTorque (torque); 


        // TO-DO: complete this class
	}
		
	private void Update () 
    {
        // TO-DO: complete this class

    }

    private void FixedUpdate()
    {
		float x = transform.position.x; 
		float y = transform.position.y; 
		
		if (x < MinX)
			x = MaxX;
		else if (x > MaxX)
			x = MinX; 
		if (y < MinY)
			y = MaxY;
		else if (y > MaxY)
			y = MinY; 
		
		transform.position = new Vector3 (x, y, transform.position.z); 
    }
    #endregion

//	void OnTriggerEnter2D(Collider2D other)
//	{
//		if(GetComponent<Collider>().gameObject.tag == "ShipBullet") 
//		   {
//				Destroy (gameObject); 
//				Destroy (GetComponent<Collider>().gameObject); 
//				Debug.Log ("Boom"); 
//			}
//
//	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("Ive been HIT!");
		//Destroy (GetComponent<Collider2D> ().gameObject);
		//Destroy (gameObject);

		if (Health == 1) {
			Destroy (GetComponent<Collider2D> ().gameObject);
			Destroy (gameObject);
		}
		Health --; 
//		if (GetComponent<Collider2D> ().gameObject.tag == "ShipBullet") 
//		{ 
//			Debug.Log ("Boom"); 
//		}
//		
//		if (gameObject.tag == "ShipBullet") 
//		{ 
//			Debug.Log ("Boom"); 
//		}
					
	}
}