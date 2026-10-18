
using Unity.Profiling;
using UnityEngine;

public class Move_System : MonoBehaviour
{
    [Header("RigidBodies")]
    [SerializeField] private Rigidbody2D player;

    [Header("Variables")]
    [SerializeField] private float speed = 0;

    [SerializeField] private bool isgrounded = false;

    [SerializeField] private float raycastHeight = -.2f;

    [SerializeField] private float JumpHeight = 5;

    private string[] Jump = { "Platform", "Ground" };
    private void Update()
    {
        // Movement for X Value
        float x = Input.GetAxisRaw("Horizontal");
        move(x);
        checkground(ref isgrounded);
        jump(isgrounded);
    }








    private void move(float x)
    {

        //Player Velocity                InputRaw * speed Actual || player velocity
        player.linearVelocity = new Vector2(x * speed, player.linearVelocity.y);
    }

    private void checkground(ref bool isgrounded)
    {
        //Sends a raycast down to see if it is grounded and ready to jump
       
 isgrounded = Physics2D.Raycast(transform.position, Vector2.down, raycastHeight, LayerMask.GetMask(Jump));
            
        
       
    }


    private void jump(bool isgrounded)
    {
        //If it is grounded and either space or W is clicked then jump
        if (isgrounded == true && Input.GetKeyDown(KeyCode.W) )
        {
player.AddForce(Vector2.up * JumpHeight);
        }
        
    }



}
