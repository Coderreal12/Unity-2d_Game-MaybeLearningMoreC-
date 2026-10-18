using UnityEngine;

public class SetParent : MonoBehaviour
{

    private bool plattouch = false;


    [SerializeField] private GameObject player;
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject Defualt;


    private void Update()
    {
        SendRay(ref plattouch);
        
        //If Touching the platform
        
ParentPlayer(ref player, ref platform, plattouch);
        
        


    }


    private void SendRay(ref bool plattouch)
    {
        plattouch = Physics2D.Raycast(transform.position, Vector2.down, -.2f, LayerMask.GetMask("Platform"));
    }

    private void ParentPlayer(ref GameObject player, ref GameObject platform, bool plattouch)
    {
        //If touching

        if(plattouch)
        {
            //Parrent player to platform
                player.transform.SetParent(platform.transform, true);
        }
        else
        {
            //Parent Player to Defualt
                player.transform.SetParent(Defualt.transform, true);
        }
    }

   


}
