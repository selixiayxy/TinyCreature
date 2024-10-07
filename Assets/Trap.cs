using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    public string SceneName;// Start is called before the first frame update
   private void onTriggerEnter(Collider2D collision){
    Debug.Log("Collision Happen");
   }
}
