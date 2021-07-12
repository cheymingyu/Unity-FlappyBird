using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField]
    private KeyCode keyCodeJump = KeyCode.Space;

    private Movement2D movement2D;
    [SerializeField]
    private float jumpForce = 6.0f;
    private AudioSource audioSource;
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
        rigid2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyCodeJump))
        {
            rigid2D.velocity = Vector3.up * jumpForce;
            transform.rotation = Quaternion.Euler(0, 0, 15);
            audioSource.Play();
        }
        if (rigid2D.velocity.y < -2 && rigid2D.velocity.y > -4)
        {
            transform.Rotate(0, 0, -2.5f);
        }

    }
}
