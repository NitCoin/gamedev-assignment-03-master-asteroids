using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    #region Public Member Variables
    [Header("Prefabs")]
    public GameObject[] AsteroidPrefabs;

    [Header("Global Properties")]
    public Vector2 AsteroidSizeBounds = new Vector2(0.8f, 3.5f);    
    #endregion

    #region Unity Methods    


	private void Start ()
    {
        // TO-DO: complete this class
	}
		
	void Update () 
    {
        // TO-DO: complete this class

    }
    #endregion
}
