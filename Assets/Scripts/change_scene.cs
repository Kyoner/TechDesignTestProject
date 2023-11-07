using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour 
{
    public void ChangeScene(int scene_id)
    {
        SceneManager.LoadScene(scene_id);
    }
}