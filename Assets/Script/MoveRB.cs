using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float speed = 5f; // ความเร็วของการเคลื่อนที่

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // เข้าถึง RigidBody ของอ็อบเจกต์
    }

    void FixedUpdate()
    {
        // ดึงอินพุตจากผู้ใช้
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // สร้างเวกเตอร์ที่บอกทิศทางการเคลื่อนที่
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // ใช้ RigidBody เพื่อเคลื่อนที่อ็อบเจกต์
        rb.AddForce(movement * speed);
    }

}
