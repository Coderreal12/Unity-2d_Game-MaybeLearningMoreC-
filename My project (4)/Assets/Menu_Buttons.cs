using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_Buttons : MonoBehaviour
{

private int resp = 0;
    public void Respawn()
    {
        SceneManager.LoadScene(resp);
    }
}
