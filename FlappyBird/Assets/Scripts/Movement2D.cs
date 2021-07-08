using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;
    [SerializeField]
    private float jumpForce = 6.0f;
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        if (rigid2D.velocity.y < -1 && rigid2D.velocity.y > -3)
        {
            transform.Rotate(0, 0, -2.0f);
        }
    }

    public void MoveTo(Vector3 direction)
    {
        moveDirection = direction;
    }

    public void Jump()
    {
        rigid2D.velocity = Vector3.up * jumpForce;
        transform.rotation = Quaternion.Euler(0, 0, 15);
    }
}
