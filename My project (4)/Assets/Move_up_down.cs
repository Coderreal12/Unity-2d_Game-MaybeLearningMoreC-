using UnityEngine;

public class Move_up_down : MonoBehaviour
{
    [Header("Transforms")]
    [SerializeField] private Transform PointA;

    [SerializeField] private Transform PointB;

    [SerializeField] private Transform CurrentPoint;

    [Header("Variables")]
    [SerializeField] private float speed = 5f;

    private void Awake()
    {
        CurrentPoint.position = PointA.position;
    }
    void Update()
    {
        //Move's Toward the point
        moveto(PointA, PointB);
        //If the point is touching Either A or b set the current point equal to either one.
        change(PointA, PointB, ref CurrentPoint);

    }



    private void moveto(Transform pointA, Transform pointB)
    {
        transform.position = Vector3.MoveTowards(transform.position, CurrentPoint.position, speed * Time.deltaTime);
    }

    private void change(Transform pointA, Transform pointB, ref Transform CurrentPoint)
    {
          if (transform.position == pointA.position)
        {
            CurrentPoint.position = pointB.position;
        }

        else if(transform.position == pointB.position)
        {
            CurrentPoint.position = pointA.position;
        }

    }






}
