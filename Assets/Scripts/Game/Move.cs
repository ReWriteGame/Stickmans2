using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    [SerializeField] [Range(0, 20)] private float speed = 10;

    [SerializeField] private Vector3 direction;


    #region events, properties and fields
    // могу ли я прыгать
    private bool canMove = true;
    private bool canJump = false;
    // действую ли я
    private bool isMoving = false;
    private bool isJumping = false;

    private Rigidbody rb;

    #endregion

    public bool IsMoving { get => isMoving; }
    public bool IsJumping { get => isJumping; }
    public float Speed { get => speed; }

    public bool CanMove { get => canMove; set => canMove = value; }
    public bool CanJump { get => canJump; set => canJump = value; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    public void Forward()
    {
        direction += Vector3.forward;
        isMoving = true;
    }
    public void Back()
    {
        direction += Vector3.back;
        isMoving = true;
    }
    public void Right()
    {
        direction += Vector3.right;
        isMoving = true;
    }
    public void Left()
    {
        direction += Vector3.left;
        isMoving = true;
    }

    public void Stop()
    {
        direction = Vector3.zero;
        isMoving = false;
    }

    public void VectorDirection(Vector3 moveDirection)
    {
        direction = moveDirection;
        isMoving = true;
    }



    void MoveLogics()
    {
        if (canMove)
        {
            Vector3 force = direction.normalized * speed;
            rb.AddForce(rb.mass * force);//  увеличим силу пропорционально массе 
        }
    }
    
    private void FixedUpdate()
    {
        MoveLogics();
    }
}
