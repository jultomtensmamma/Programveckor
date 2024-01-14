using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour  
{
 
    Rigidbody2D myRigidbody;
    [SerializeField] private UI_Inventory uiInventory;
    [SerializeField] private ItemHolder itemHolder;
    // Start is called before the first frame update
    private void Awake()
    {
        itemHolder = new ItemHolder();
        uiInventory.SetItemHolder(itemHolder);
    }
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        transform.position = new Vector3(0, 2, 0);

       

    }

    // Update is called once per frame
    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
            myRigidbody.AddForce(new Vector3(0, 5, 0), ForceMode2D.Impulse);
       }
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(new Vector3(6, 0, 0));

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddForce(new Vector3(-6, 0, 0));
        }

    }
}
