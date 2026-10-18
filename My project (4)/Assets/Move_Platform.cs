using UnityEngine;
using UnityEngine.UIElements;

public class Move_Platform : MonoBehaviour
{
    [Header("Transforms")]
    [SerializeField] private Transform pointB;
    [SerializeField] private Transform pointA;
    public Transform travelpoint;
    [Header("Variables")]
    [SerializeField] private float speed = 5f;

    private void Awake()
    {
        travelpoint.position = pointA.position;
    }

    public void Update()
    {

Checkhitmove(pointA,pointB,ref travelpoint);
        //Saying go to the next point that I set in here.           
        transform.position = Vector3.MoveTowards(transform.position,travelpoint.position , speed * Time.deltaTime);


  

    }


    private void Checkhitmove(Transform pointA, Transform PointB, ref Transform travelpoint)
    {
        if (transform.position == pointA.position)
        {
            travelpoint.position = pointB.position;
        }
         if (transform.position == pointB.position)
        {
            
            travelpoint.position = pointA.position;
        }
                
    }



}
