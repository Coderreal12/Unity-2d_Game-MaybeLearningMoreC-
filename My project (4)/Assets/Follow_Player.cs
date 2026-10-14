using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    [Header("Transforms")]
    [SerializeField] private Transform player;

    public void Update()
    {
        Vector3 follow = new Vector3(player.position.x, player.position.y, -10f);

        transform.position = follow;
    }

}
