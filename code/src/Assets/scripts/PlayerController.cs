using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
 {
    if(other.gameObject.name =="PortalToFort"){
        Debug.Log("PortalToFort touché --> scène Fort lancée");
        SceneManager.LoadScene("Fort");}

    else if(other.gameObject.name =="PortalToBeach"){
        Debug.Log("PortalToBeach touché --> scène VideoBeach lancée");
        SceneManager.LoadScene("VideoBeach");}

        else if(other.gameObject.name =="PortalToBeach2"){
        Debug.Log("PortalToBeach touché --> scène VideoBeach2 lancée");
        SceneManager.LoadScene("VideoBeach2");}

            else if(other.gameObject.name =="PortalToSea"){
                Debug.Log("PortalToSea touché --> scène VideoSea lancée");
                SceneManager.LoadScene("VideoSea");}

                else if(other.gameObject.name =="PortalToEarth"){
                    Debug.Log("PortalToEarth touché --> scène VideoEarth lancée");
                    SceneManager.LoadScene("VideoEarth");}

                    else if(other.gameObject.name =="PortalToHub"){
                        Debug.Log("PortalToHub touché --> scène Hub lancée");
                        SceneManager.LoadScene("Hub");}

                            else if(other.gameObject.name =="Water"){
                        Debug.Log("Water touché --> scène relancée");
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}
 
}

}
