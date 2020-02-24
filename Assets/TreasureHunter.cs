using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHunter : MonoBehaviour
{
    // Start is called before the first frame update

    

    public TextMesh text1; 

    public TextMesh text2; 

    public TextMesh text3;

    

    public Inventory myInventory; 

    List<GameObject> myList ; 

    //public Camera mainCam; 

    private int scoreCounter = 0; 

    private int numItems = 0; 


    void Start()
    {
        myList = myInventory.list; 
    }

    // Update is called once per frame
    void Update()
    {
        
        
        // if(Input.GetMouseButtonDown(0)){



            
        // RaycastHit hit;
        // // Does the ray intersect any objects excluding the player layer
        // if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit))
        // {
        //     
        
    }

    void OnTriggerExit(Collider other)
    {
       if(other.gameObject.name.Contains("Sphere")){
                numItems++; 

                text1.text = "Num Items: " + numItems; 

                scoreCounter = scoreCounter + other.gameObject.GetComponent<Score>().points; 

                text2.text = "Score: " + scoreCounter;

                Debug.Log(other.gameObject.GetComponent<Score>().prefabName);

                myInventory.list.Add(Resources.Load(other.gameObject.GetComponent<Score>().prefabName, typeof(GameObject)) as GameObject);

                text3.text = "I have Collected: " + other.gameObject.name;

                Destroy(other.gameObject);

            }

        if(other.gameObject.name.Contains("Cube")){
            numItems++; 

            text1.text = "Num Items: " + numItems; 

            scoreCounter = scoreCounter + other.gameObject.GetComponent<Score>().points; 

            text2.text = "Score: " + scoreCounter;

            Debug.Log(other.gameObject.GetComponent<Score>().prefabName);

            myInventory.list.Add(Resources.Load(other.gameObject.GetComponent<Score>().prefabName, typeof(GameObject)) as GameObject);

            text3.text = "I have Collected: " + other.gameObject.name;

            Destroy(other.gameObject);
        }

        if(other.gameObject.name.Contains("Capsule")){
                numItems++; 

            text1.text = "Num Items: " + numItems; 

            scoreCounter = scoreCounter + other.gameObject.GetComponent<Score>().points; 

            text2.text = "Score: " + scoreCounter;

            Debug.Log(other.gameObject.GetComponent<Score>().prefabName);

            myInventory.list.Add(Resources.Load(other.gameObject.GetComponent<Score>().prefabName, typeof(GameObject)) as GameObject);

            text3.text = "I have Collected: " + other.gameObject.name;

            Destroy(other.gameObject);
        }
        

        if(other.gameObject.name.Contains("Cylinder")){
                 numItems++; 

                text1.text = "Num Items: " + numItems; 

                scoreCounter = scoreCounter + other.gameObject.GetComponent<Score>().points; 

                text2.text = "Score: " + scoreCounter;

                Debug.Log(other.gameObject.GetComponent<Score>().prefabName);

                myInventory.list.Add(Resources.Load(other.gameObject.GetComponent<Score>().prefabName, typeof(GameObject)) as GameObject);

                text3.text = "I have Collected: " + other.gameObject.name;

                Destroy(other.gameObject);
            }
    }
}
