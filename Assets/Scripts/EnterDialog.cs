using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDialog : MonoBehaviour
{
   public GameObject enterdialog;

   private void onTriggerEnter2D(Collider2D collision){
    if(collision.tag=="Player"){
       enterdialog.SetActive(true);    }
   }
}
