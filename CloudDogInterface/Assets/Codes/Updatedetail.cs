using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Updatedetail : MonoBehaviour {

    public InputField strong;
    public InputField Need;
    public Text inputtext;

    public void updateDetail()
    {
        inputtext.text = "Your strong point is " + strong.text + " and you need a partner which is good at " + Need.text;
    }
}
