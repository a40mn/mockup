using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private float horizontalInput;
  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("horizontal");
        
    }
}
