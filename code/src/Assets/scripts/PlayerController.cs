using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
 {
    if(other.gameObject.name =="Portal1"){
        SceneManager.LoadScene("video1");}

    else if(other.gameObject.name =="Portal2"){
    SceneManager.LoadScene("video2");}

    else if(other.gameObject.name =="Water"){
        transform.position = new Vector3(4, 0, -2);}
 
}

}
