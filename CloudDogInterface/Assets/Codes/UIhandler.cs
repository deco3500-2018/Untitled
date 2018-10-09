using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class UIhandler : MonoBehaviour {
    public Image nav;
    

    public void navStart() {
        nav.gameObject.SetActive(true);
        nav.fillAmount = 0.25f;
       



    }    
}
