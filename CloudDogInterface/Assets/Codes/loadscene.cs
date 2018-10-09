using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour {
    /* The code below has been adapted from
   https://docs.unity3d.com/ScriptReference/Application.LoadLevel.html
   I have changed variable types to achieve the funtion to another scene */
    public void changemeunscene(string scenename) {
        Application.LoadLevel("Part2");
    }
}
