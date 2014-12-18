using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginGame : MonoBehaviour {

    public InputField username;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Login()
    {
        Debug.Log("user : " + username.text + " request login game...");
    }
}
