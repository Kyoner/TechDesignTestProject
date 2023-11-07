using UnityEngine;

public class animation_on_click : MonoBehaviour
{
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Animator>().SetTrigger("start_trigger");
        }
    }
}
