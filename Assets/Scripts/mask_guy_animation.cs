using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mask_guy_animation : MonoBehaviour
{
    int sceneid;
    private void Start()
    {
        sceneid = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(sceneid == 0)
                gameObject.GetComponent<Animator>().SetTrigger("run_trigger");
            else
                gameObject.GetComponent<Animator>().SetTrigger("hit_trigger");
        }
    }
}
