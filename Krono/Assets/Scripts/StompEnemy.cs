using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompEnemy : MonoBehaviour {
 
    // sound effect source
     public AudioSource stompSFX;
    
	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	//void Update () {
		
	//}
    
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            stompSFX.Play();
            Destroy(other.gameObject);
        }
    }
}
