using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour {
    /* The code snippet (2. output loop) below has been adapted from
   https://www.youtube.com/watch?v=o9Sl0GwRzx0
   I have changed variable types to get the function to show the text from inputfield. */
    public InputField Chat;
    public Text fText;

    public void setget() {
        fText.text = Chat.text;
    }
}
