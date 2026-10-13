using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header ("Variables")]
    [SerializeField] private float Speed;
    [SerializeField] private float Jump_Height;
    


    [Header("RigidBodies2D")]
    [SerializeField] Rigidbody2D Player;

    [Header("Scripts")]
    [SerializeField] Ground_Collder colider;


    //Private Variables;
    private float x;
    private float y;




    // Update is called once per frame
    private void Awake()
    {
        Player = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
     
        y = Input.GetAxisRaw("Horizontal");
        
if (colider.IsGrounded && Input.GetKeyDown(KeyCode.W))
        {
            Player.linearVelocity = new Vector2(0, 0);
Player.AddForce(new Vector2(0,Jump_Height * Time.deltaTime));
        }

    }

    private void FixedUpdate()
    {
       
            

             
        
        



        Player.AddRelativeForce(new Vector2(y * Speed, 0));

        Player.linearVelocity = new Vector2(0, Player.linearVelocity.y);
    }


}
