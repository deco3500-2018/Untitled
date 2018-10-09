using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getReply : MonoBehaviour {

    /* The code below has been adapted from
    https://www.youtube.com/watch?v=bYG5K3xRjuU
    I have changed variable types to achieve the funtion to click button and change the fillAmount to 1.0 from 0.0. */
    public Image reply;
    public Text replyText;
    public void ShowreplyContent() {
        reply.gameObject.SetActive(true);
        reply.fillAmount = 1.0f;
       
   
    }
}
