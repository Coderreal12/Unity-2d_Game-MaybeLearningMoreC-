using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] private GameObject death_screen;

    [SerializeField] private Move_System speed;

    private void Awake()
    {
        death_screen.SetActive(false);
    }


    public void Update()
    {
        
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kill"))
        {
            death_screen.SetActive(true);

            speed.change(0);
        }
    }



}
