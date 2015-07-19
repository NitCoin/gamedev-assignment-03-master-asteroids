using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    #region Public Variables
    [Header("Audio Clips")]
    public AudioClip LaserAudioClip;

    [Header("Prefabs")]
    public GameObject BulletPrefab;
    #endregion

    #region Private Member Variables
    private Rigidbody2D _Rigidbody = null;
    #endregion

    #region Unity Methods

	public float rotationSpeed = 250f; 
	public float engineSpeed = 1f; 

	public float MinX; 
	public float MaxX;
	public float MinY;
	public float MaxY; 
	
    private void Start () 
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
	    // TO-DO: code this class
	}
		
	private void Update () 
    {
        // TO-DO: code this class
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Instantiate(BulletPrefab, transform.position, transform.rotation); 
		}
    }
    private void FixedUpdate()
    {
       
		if (Input.GetKey (KeyCode.A)) 
		{
			//Rotate ship to the left.
			_Rigidbody.angularVelocity = rotationSpeed; 
		}
		else if (Input.GetKey (KeyCode.D))
		{
			//rotate to the right 
			_Rigidbody.angularVelocity = -rotationSpeed; 
		} 
		else 
		{
			_Rigidbody.angularVelocity = 0f; 
		}

		if (Input.GetKey(KeyCode.W))
		{
			//Thrust 
			Vector2 forceVector = transform.up * engineSpeed; 
			_Rigidbody.AddForce(forceVector); 

		}
		if (Input.GetKey (KeyCode.S)) 
		{
			_Rigidbody.AddForce(transform.up * -engineSpeed); 
		}

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
}
