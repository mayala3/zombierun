using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    // Reference to Rigidbody component of Player
    public Rigidbody rb;

    // Amount of force for movement of the player
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardForce = 500f;

    public float jumpDegredation;

	// FixedUpdate is called once per frame
    // Used because we are using physics
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);       // adds a forward force
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*if (Input.GetKeyDown("d") && transform.position.x < 4f)
        {
            Debug.Log("Right");
            //rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            transform.position = new Vector3(transform.position.x + 5f, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown("a") && transform.position.x > -4f)
        {
            Debug.Log("Left");
            transform.position = new Vector3(transform.position.x - 5f, transform.position.y, transform.position.z);
        }*/

        if (Input.GetKeyDown("space"))
        {
            // jumpdegredation updates every time space is pressed
            // fix it!!
            rb.AddForce(0, upwardForce * Time.deltaTime * ((jumpDegredation - GameManage.zombies*GameManage.zombies)/100), 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManage>().EndGame();
        }
    }
}
