using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound=30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z>topBound)
        {
            Destroy(gameObject);
        }
    }
}
