using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using statement for unity ui code
using UnityEngine.UI;

public class GemCount : MonoBehaviour {
       
    //variable to track the visible text count
    //  Public to let us drag and drop in the editor

        public Text gemText;

    //variable to track numerical count
    //  private because other scripts should not change it directly
    //Default to 0 since we should not have any score when starting
    private int numericalGems = 0;
        
        
        
        
        
        // Use this for initialization
	void Start () {
        //get the score from the prefs database
        //use a default of 0 if no score was saved
        //store result in numberical score variable
        numericalGems = PlayerPrefs.GetInt("gems", 0);

        //update visual score
        gemText.text = numericalGems.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    //function to increase the count
    //public so other scripts can use it such as the coin
    public void AddGems(int _toAdd)
    {
        //add the amount to the numerical score
        numericalGems = numericalGems + _toAdd;

        //update the visual score
        gemText.text = numericalGems.ToString();

    }

    // function to save  ths core to the player preferences
    //public so it can be triggered from another script eg door
    public void SaveGems()
    {
        PlayerPrefs.SetInt("gems", numericalGems);
    }


    }

