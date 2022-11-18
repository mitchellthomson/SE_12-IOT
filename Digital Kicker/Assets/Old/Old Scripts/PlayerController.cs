using UnityEngine;

// Include the namespace required to use Unity UI
using UnityEngine.UI;

using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// Create public variables for player speed, and for the Text UI game objects
	public float speed;
	public Text countRedText;
    public Text countBlueText;
	public Text winText;
    public Vector3 movement;

	// Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
	private Rigidbody rb;
	private int countRed;
    private int countBlue;
    private float dist = 60.0f;
    
	// At the start of the game..
	void Start ()
	{
        
        
		// Assign the Rigidbody component to our private rb variable
		rb = GetComponent<Rigidbody>();
        
        Debug.Log("Starting Game");
        reset(0.0f, 8.0f, 0.0f);
        movement = Vector3.zero;

		// Set the count to zero 
		countRed = 0;
        countBlue = 0;

		// Run the SetCountText function to update the UI (see below)
		SetCountRedText ();
        SetCountBlueText ();

		// Set the text property of our Win Text UI to an empty string, making the 'You Win' (game over message) blank
		winText.text = "";
	}
	
	void reset(float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
        
    }

	// Each physics step..
	void FixedUpdate ()
	{
		// Set some local float variables equal to the value of our Horizontal and Vertical Inputs
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// Add a physical force to our Player rigidbody using our 'movement' Vector3 above, 
		// multiplying it by 'speed' - our public player speed that appears in the inspector
        rb.AddForce (movement * speed);
	}

	// When this game object intersects a collider with 'is trigger' checked, 
	// store a reference to that collider in a variable named 'other'..
	void OnTriggerEnter(Collider other) 
	{        
		// ..and if the game object we intersect has the tag 'Red or Blue' assigned to it..
		if (other.gameObject.CompareTag ("Blue"))
		{
			// Add one to the score variable 'count'
			countRed = countRed + 1;
            reset(dist, 0.0f, 0.0f);
            SetCountRedText();
		}
		if (other.gameObject.CompareTag ("Red"))
		{
			// Add one to the score variable 'count'
			countBlue = countBlue + 1;
            reset(-dist, 0.0f, 0.0f);
            SetCountBlueText();
		}
	}

	// Create a standalone function that can update the 'countText' UI and check if the required amount to win has been achieved
	void SetCountRedText()
	{
            
        Debug.Log("Red: " + countRed.ToString());
        
		// Update the text field of our 'countText' variable
		countRedText.text = "Red: " + countRed.ToString ();

		// Check if our 'count' is equal to or exceeded 1
		if (countRed >= 10) 
		{
			// Set the text value of our 'winText'
			winText.text = "Red Wins!";
            resetGame();
		}
	}
	void SetCountBlueText()
	{
        
        Debug.Log("Blue: " + countBlue.ToString());
        
		// Update the text field of our 'countText' variable
		countBlueText.text = "Blue: " + countBlue.ToString ();

		// Check if our 'count' is equal to or exceeded 1
		if (countBlue >= 10) 
		{
			// Set the text value of our 'winText'
			winText.text = "Blue Wins!";
            resetGame();
		}
	}
	
	void resetGame()
    {
        rb.velocity = Vector3.zero;
        reset(0.0f, 8.0f, 0.0f);
        countRed = 0;
        countBlue = 0;
        winText.text = "";
    }
}
