using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlBox : MonoBehaviour {
    public bool is_appear = true;
    public Text Clicktext;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Cube")
            {

                Destroy(hit.transform.gameObject);        //물체 사라짐
                is_appear = false;

            }
        }

        if (!is_appear)
        {
            Clicktext.text = " ";
        }

    }
}
