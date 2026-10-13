using UnityEngine;

public class Ground_Collder : MonoBehaviour
{
    public bool IsGrounded = true;

    private void Update()
    {
        IsGrounded = Physics2D.Raycast(transform.position, Vector2.down,  - .2f, LayerMask.GetMask("Ground"));

        Vector2 Playerpos = (transform.position);
        Debug.DrawLine(transform.position, Playerpos + Vector2.down *  - .2f, Color.red);


    }


}
