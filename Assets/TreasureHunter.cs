using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHunter : MonoBehaviour
{
    // Start is called before the first frame update

    public Inventory iv; 

    public TextMesh text1; 

    public TextMesh test2; 


    public GameObject treasure1;
    public GameObject treasure2; 
    public GameObject treasure3; 

    public Inventory myInventory; 

    List<GameObject> myList ; 


    void Start()
    {
        myList = myInventory.list; 
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown("1"))
        {
            if(!myList.Contains(treasure1)){
                myList.Add(treasure1);
            }
        }

        if (Input.GetKeyDown("2"))
        {
             if(!myList.Contains(treasure2)){
                myList.Add(treasure2);
            }
        }

        if (Input.GetKeyDown("3"))
        {
             if(!myList.Contains(treasure3)){
                myList.Add(treasure3);
            }
        }

        if (Input.GetKeyDown("4"))
        {
            int score = 0; 
            foreach(GameObject treasure in myList)
            {  
               score += treasure.GetComponent<Score>().points; 
               test2.text += " " + treasure.name; 
            }

            test2.text += " Score is: " + score; 
        }
    }
}
