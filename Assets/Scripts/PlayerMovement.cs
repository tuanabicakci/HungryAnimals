using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 10f;

    public float xRange = 10f;

    public Vector3 playerPosition;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        playerPosition = transform.position;

        if (playerPosition.x < -xRange)
        {
            playerPosition = new Vector3(-xRange, playerPosition.y, playerPosition.z);
        }

        if (playerPosition.x > xRange)
        {
            playerPosition = new Vector3(xRange, playerPosition.y, playerPosition.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        playerPosition += Vector3.right * (horizontalInput * Time.deltaTime * speed);

        // Apply the modified position to the actual transform.position
        transform.position = playerPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, playerPosition, projectilePrefab.transform.rotation);
        }
    }
}
