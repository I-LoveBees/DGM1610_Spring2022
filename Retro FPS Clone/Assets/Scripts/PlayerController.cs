using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance; //static means its a one time instance that we can ref directly (?)
    public float moveSpeed;
    private Rigidbody rb; 
    private Vector3 moveInput;
    private Vector2 mouseInput;
    public float mouseSensitivity = 1.0f;
    public Camera viewCam;
    public GameObject bulletImpact;
    public int currentAmmo;
    
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Hide and lock cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveH = transform.right * moveInput.x; //left and right movement
        Vector3 moveV = transform.forward * moveInput.z; //foreward and backwards
        rb.velocity = (moveH + moveV) * moveSpeed; //combines above vector3 to make you go diagonal :)

        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z); //calulating the rotation, its more effective this way

        if(Input.GetMouseButtonDown(0))
        {
            if(currentAmmo > 0)
          {
            Ray ray = viewCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));
            RaycastHit hit; //this variable is only good in this conditional

            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log("I'm looking at " + hit.transform.name);
                Instantiate(bulletImpact, hit.point, transform.rotation);
            }
            else
            {
                Debug.Log("I'm not looking at anything");
            }
          }

            currentAmmo --;
          
        }
        
    }
}
