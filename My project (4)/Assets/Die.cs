using UnityEngine;
using TMPro;
using System;
public class Die : MonoBehaviour
{
    [SerializeField] private GameObject death_screen;

    [SerializeField] private Move_System speed;

    [SerializeField] private GameObject Defualt_screen;

    [SerializeField] private int score = 0;

    [SerializeField] private TMPro.TextMeshProUGUI sc;

    [SerializeField] private float  add;

    private int time;

    [SerializeField] private TMPro.TextMeshProUGUI tm;
    private void Awake()
    {
        death_screen.SetActive(false);
        Defualt_screen.SetActive(true);


    }


    public void Update()
    {
        add += Time.deltaTime;

        time = Convert.ToInt32(add);
        sc.SetText($"Score: " + score);

        tm.SetText($"Time: {time}");
        if (score == 5)
        {
            Time.timeScale = 0;
            sc.SetText($"You have won with a time of" + time);
        }
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kill"))
        {
            Defualt_screen.SetActive(false);
            death_screen.SetActive(true);

            speed.change(0);
        }
         
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            score++;
            Destroy(collision.gameObject);

        }
    }

}
