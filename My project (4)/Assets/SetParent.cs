using UnityEngine;

public class SetParent : MonoBehaviour
{

    private bool plattouch = false;


    [SerializeField] private GameObject player;
    [SerializeField] private GameObject platform;



    private void Update()
    {
        SendRay(ref plattouch);
        
        //If Touching the platform
        if(plattouch)
        {
            Debug.Log("I am touching the platfomr");
            //Parent the player to the platfomrm
ParentPlayer(ref player, ref platform);
        }
        


    }


    private void SendRay(ref bool plattouch)
    {
        plattouch = Physics2D.Raycast(transform.position, Vector2.down, -.2f, LayerMask.GetMask("Platform"));
    }

    private void ParentPlayer(ref GameObject player, ref GameObject platform)
    {
        player.transform.SetParent(platform.transform, true);
    }



}
