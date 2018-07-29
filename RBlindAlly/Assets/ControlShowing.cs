using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlShowing : MonoBehaviour
{
    public BoxTracking bt;
    public Text Clicktext;
    public ControlBox bas;
    public RawImage GetImage;

    // Use this for initialization
    void Start()
    {
        Clicktext.text = " ";
        GetImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (bt.is_detected_)
        {
            if (!bas.is_appear) //박스가 사라졌다면
            {
                GetImage.gameObject.SetActive(true);
                Clicktext.text = " ";
                Destroy(GetImage.gameObject, 2.0f);
            }
            else
            {
                Clicktext.text = "획득하려면 나무함을 누르시오.";
            }

        }
        else
        {

            Clicktext.text = " ";
        }
    }

}
