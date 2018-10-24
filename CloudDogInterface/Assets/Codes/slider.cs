using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour {
    
    public Text sliderText;
    public Slider slider1;

    private void Update()
    {
        sliderText.text = slider1.value.ToString();
    }
}
