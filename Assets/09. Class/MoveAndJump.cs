using UnityEngine;
using UnityEngine.InputSystem;

public class MoveAndJump : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float jumpHeight = 5f;
    public float gravity = -9.8f;

    private float leftLimit = -3f;
    private float rightLimit = 3f;
    private float moveDirection = 1f;

    private float verticalVelocity = 0f;
    private bool isJumping = false;
    private float groundY;
    private Vector3 jumpStartPos;

    void Start()
    {
        groundY = transform.position.y;
    }

    void Update()
    {
        if (!isJumping)
        {
            MoveHorizontally();

            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                StartJump();
            }
        }
        else
        {
            ApplyJump();
        }
    }

    void MoveHorizontally()
    {
        Vector3 pos = transform.position;

        if (pos.x >= rightLimit)
            moveDirection = -1f;
        else if (pos.x <= leftLimit)
            moveDirection = 1f;

        transform.position += Vector3.right * moveDirection * moveSpeed * Time.deltaTime;
    }

    void StartJump()
    {
        isJumping = true;
        verticalVelocity = Mathf.Sqrt(-2f * gravity * jumpHeight);
        jumpStartPos = transform.position;
    }

    void ApplyJump()
    {
        verticalVelocity += gravity * Time.deltaTime;
        transform.position += Vector3.up * verticalVelocity * Time.deltaTime;

        if (transform.position.y <= groundY)
        {
            Vector3 pos = transform.position;
            pos.y = groundY;
            transform.position = pos;

            // 원래 jump 시작 위치의 x로 복귀
            Vector3 backToX = transform.position;
            backToX.x = jumpStartPos.x;
            transform.position = backToX;

            isJumping = false;
            verticalVelocity = 0f;
        }
    }
}
