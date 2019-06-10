using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    //variable to let us add to the score
    // public so we can drag and drop
    public CollectableCount fragObject;

    //Variable to hold the coin's point value
    // Public so we can change in editor
    public int fragValue;

    //Audio source
    public AudioSource collectSFX;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //unity calls this function when our coin touches any other object
    // if the player touched us the coin should vanish and score go up

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        //check if the thing we touched was the player
        Player playerScript = collision.collider.GetComponent<Player>();

        //if the thing we touched has a player script, it is a player
        if (playerScript)
        {
            //Player hit

            


            //Add to score based on value
            fragObject.AddScore(fragValue);

            //Play audio
            collectSFX.Play();

            //Destroy the gameObject that this script is attached to (the coin)
            Destroy(gameObject);
        }
    }
}
