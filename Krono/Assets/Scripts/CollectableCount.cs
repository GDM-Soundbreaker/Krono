﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using statement for unity ui code
using UnityEngine.UI;

public class CollectableCount : MonoBehaviour {
       
    //variable to track the visible text score
    //  Public to let us drag and drop in the editor

        public Text fragText;

    //variable to track numerical score
    //  private because other scripts should not change it directly
    //Default to 0 since we should not have any score when starting
    private int numericalFrag = 0;
        
        
        
        
        
        // Use this for initialization
	void Start () {
        //get the score from the prefs database
        //use a default of 0 if no score was saved
        //store result in numberical score variable
        numericalFrag = PlayerPrefs.GetInt("frag", 0);

        //update visual score
        fragText.text = numericalFrag.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    //function to increase the score
    //public so other scripts can use it such as the coin
    public void AddScore(int _toAdd)
    {
        //add the amount to the numerical score
        numericalFrag = numericalFrag + _toAdd;

        //update the visual score
        fragText.text = numericalFrag.ToString();

    }

    // function to save  ths core to the player preferences
    //public so it can be triggered from another script eg door
    public void SaveScore()
    {
        PlayerPrefs.SetInt("frag", numericalFrag);
    }


    }

