using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class sphereShooter : MonoBehaviour {

	// Variables
	public GameObject spherePrefab;
	public GameObject mainCamera;

	Renderer rend;		

	
	
	// Use this for initialization
	void Start () {
	
	}
	
	
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0))	
		{
			if (!EventSystem.current.IsPointerOverGameObject() ){

			sphereMethod();

			}
			
		}
	}
	
	
	// Method to create cubePrefab in scene
	void sphereMethod(){

		//INSTANTIATION
        var spherePlacementPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.175f);
        transform.position = Camera.main.ScreenToWorldPoint(spherePlacementPosition);
        GameObject instantiatedSphere = Instantiate(spherePrefab,transform.position, Quaternion.identity);
		instantiatedSphere.GetComponent<Rigidbody>().AddForce(mainCamera.transform.forward *150);
        
		//COLOR
        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);
        rend = instantiatedSphere.GetComponent<Renderer>();
        rend.material.color = new Color(r, g, b);

		//AUDIO
        AudioSource audioSource = instantiatedSphere.GetComponent<AudioSource>();
        audioSource.pitch = ((Input.mousePosition.x/Screen.width)*1.5f);
        audioSource.Play();

    }

}
