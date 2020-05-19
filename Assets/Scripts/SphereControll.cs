using UnityEngine;
using UnityEngine.UI;

public class SphereControll : MonoBehaviour
{
    //we need a global variable for Rigidbody because all the action happen through it
    private Rigidbody rb;
    //if we declare a public and global variable in Unity will be displayed as a property
    //we can change it from Unity 
    public float speed;

    //variable count will store the points, beiing private is not available in Inspector
    private int count;
    //a Text variable to store and display a message
    public Text countText;
    public Text wintext;
    // Start is called before the first frame update
    //check every frame for input
    void Start()
    {
        //rb variable has the state of the player
        rb = GetComponent<Rigidbody>();
       
        count = 0;
        wintext.text = "";
        SetCountText();
    }

    // Update is called once per frame
    //apply the input to the player every frame 
    void Update()
    {
        //read input from keyboard from horizontal by reading the axis
        float moveHorizontal = Input.GetAxis("Horizontal");
        //read input from keyboard from vertical by reading the axis
        float moveVertical = Input.GetAxis("Vertical");
        //Vector3 stores the value for the 3 axes (x,y,z)
        //in this way is easier to update all 3 axes at the same time
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //the value of the variable is continuously updated through AddForce function 
        //by multiplying where to move and with which speed
        rb.AddForce(movement*speed);
    }

    //function OnTriggerEnter is called when the player collide with a Trigger Collider
    //other is reference for the Trigger Collider
    void OnTriggerEnter(Collider other)
    {
        //is checked if the collision is with an object that have the tag "Pick Up"
        if (other.gameObject.CompareTag("Pick Up"))
        {
            //if is true the object will be set as false, will dissapear from the board
            other.gameObject.SetActive(false);
            //counter will be increased with 1
            count = count + 1;
            //function SetCountText will be called
            SetCountText();
        }
    }
    //this function display a text message and the number of the points
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        //if the number of the points will be equal with 9 a win text will be displayed
        if (count >= 9)
        {
            wintext.text = "You won!";
        }
    }
    public void forquit()
    {
        Application.Quit();
    }
}
