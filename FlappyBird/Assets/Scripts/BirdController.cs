using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField]
    private KeyCode keyCodeJump = KeyCode.Space;

    private Movement2D movement2D;

    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyCodeJump))
        {
            movement2D.Jump();
        }

    }
}
