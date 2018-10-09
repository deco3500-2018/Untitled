using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour {
    /* The code below has been adapted from
   https://www.youtube.com/watch?v=Pzd2ohvyVtQ.
   I have changed variable 0-1 to Amount "Age" and set them as whole numbers */
    public Text sliderText;
    public Slider slider1;

    private void Update()
    {
        sliderText.text = slider1.value.ToString();
    }
}
