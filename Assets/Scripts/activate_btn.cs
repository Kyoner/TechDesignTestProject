using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class activate_btn : MonoBehaviour
{
    [SerializeField] private Button btn;
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            btn.gameObject.SetActive(true);
        }
    }
}
