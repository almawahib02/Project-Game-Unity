using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] private float kecepatanRotasi = 100f;
    [SerializeField] private float mouseX, mouseY;

    public Transform player, target;

    // Start is called before the first frame update
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * kecepatanRotasi;
        mouseY -= Input.GetAxis("Mouse Y") * kecepatanRotasi;

        mouseY = Mathf.Clamp(mouseY, -35, 65);
        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}
