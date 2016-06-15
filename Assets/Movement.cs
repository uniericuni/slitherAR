using UnityEngine;
using System.Collections;

public class Movement : Photon.MonoBehaviour
{
    private Rigidbody rb;
    private Quaternion FixedAngle;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FixedAngle = transform.rotation;
    }

    void FixedUpdate()
    {
        if (photonView.isMine)
        {
            Move();
        }
    }
    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.transform.Translate(movement);
    }

    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
            stream.SendNext(rb.position);
        else
            rb.position = (Vector3)stream.ReceiveNext();
    }
}