using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayState : BaseStateMachine
{
    //[SerializeField] private LayerMask groundLayer;
    //public Vector3 startPos;
    //public Vector3 endPos;
    //public Vector3 movingVector;
    //public float speed = 500f;
    //public Rigidbody rb;
    //public bool upCanMove;
    //public bool downCanMove;
    //public bool leftCanMove;
    //public bool rightCanMove;
    //public float raycastLength = 1f;
    //public Vector3 finishPos;
    //public float maxDistanceToMove;
    //public float playerHeight;
    //private GameObject playerChild;
    public override void Enter(GameManager gameManager)
    {
        //movingVector = Vector3.zero;
    }
    public override void Excute(GameManager gameManager)
    {
        //upCanMove = UpCheck();
        //downCanMove = DownCheck();
        //leftCanMove = LeftCheck();
        //rightCanMove = RightCheck();

        //if (Input.GetMouseButtonDown(0))
        //{
        //    startPos = Input.mousePosition;
        //    //Debug.Log("St: " + startPos);
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    endPos = Input.mousePosition;
        //    //Debug.Log("End: " + endPos);
        //    movingVector = new Vector3(endPos.x - startPos.x, endPos.y - startPos.y, endPos.z - startPos.z);
        //    if (Mathf.Abs(movingVector.x) < Mathf.Abs(movingVector.y))
        //    {
        //        if (movingVector.y > 0 && upCanMove)
        //        {
        //            //up
        //            //transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //            //rb.velocity = new Vector3(0, 0, speed * Time.deltaTime);
        //            //Debug.Log("before:" + finishPos.z);
        //            maxDistanceToMove = ((transform.position.z + 1) - transform.position.z);
        //            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), maxDistanceToMove);


        //        }
        //        else if (movingVector.y < 0 && downCanMove)
        //        {
        //            //down
        //            //transform.position += new Vector3(0, 0, -(speed * Time.deltaTime));
        //            //rb.velocity = new Vector3(0, 0, -(speed * Time.deltaTime));
        //            maxDistanceToMove = ((transform.position.z + 1) - transform.position.z);
        //            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, -(transform.position.z + 1)), maxDistanceToMove);
        //        }
        //    }
        //    else if (Mathf.Abs(movingVector.x) >= Mathf.Abs(movingVector.y))
        //    {
        //        if (movingVector.x > 0 && rightCanMove)
        //        {
        //            //right
        //            //transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //            //Vector3 targetPos = currentPos + new Vector3(1, 0, 0);
        //            //currentPos = targetPos;
        //            //Debug.DrawRay(targetPos, Vector3.down, Color.red, 10f);
        //            //RaycastHit hit;
        //            //if(Physics.Raycast(targetPos, Vector3.down, out hit, 10f))
        //            //{
        //            //    Debug.Log(hit.collider.gameObject.name);
        //            //}    
        //            //rb.velocity = new Vector3(speed * Time.deltaTime, 0, 0);
        //            //transform.Translate(transform.position.z + 0.5f,0, 0);
        //            maxDistanceToMove = 1;
        //            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), maxDistanceToMove);
        //        }
        //        else if (movingVector.x < 0 && leftCanMove)
        //        {
        //            //left
        //            //transform.position += new Vector3(-(speed * Time.deltaTime), 0, 0);
        //            //rb.velocity = new Vector3(-(speed * Time.deltaTime), 0, 0);
        //            //transform.Translate(transform.position.z + 0.5f, 0, 0);
        //            maxDistanceToMove = 1;
        //            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-(transform.position.x + 1), transform.position.y, transform.position.z), maxDistanceToMove);
        //        }
        //    }
        //}
    }
    //private bool UpCheck()
    //{
    //    Debug.DrawLine(new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), new Vector3(transform.position.x, transform.position.y, transform.position.z + 1) + Vector3.down * 1.1f, Color.red);
    //    if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), Vector3.down, out RaycastHit hit, raycastLength, groundLayer))
    //    {
    //        //Debug.Log(hit.collider.name, hit.collider.gameObject);
    //        return true;
    //    }
    //    return false;
    //}
    //private bool DownCheck()
    //{
    //    Debug.DrawLine((new Vector3(transform.position.x, transform.position.y, transform.position.z - 1)), new Vector3(transform.position.x, transform.position.y, transform.position.z - 1) + Vector3.down * 1.1f, Color.red);
    //    if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, transform.position.z - 1), Vector3.down, raycastLength, groundLayer))
    //    {
    //        finishPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.5f);
    //        return true;
    //    }
    //    return false;
    //}
    //private bool LeftCheck()
    //{
    //    Debug.DrawLine(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), new Vector3(transform.position.x - 1, transform.position.y, transform.position.z) + Vector3.down * 1.1f, Color.red);
    //    if (Physics.Raycast(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), Vector3.down, raycastLength, groundLayer))
    //    {
    //        //finishPos = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
    //        return true;
    //    }
    //    return false;
    //}
    //private bool RightCheck()
    //{
    //    Debug.DrawLine(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), new Vector3(transform.position.x + 1, transform.position.y, transform.position.z) + Vector3.down * 1.1f, Color.red);
    //    if (Physics.Raycast(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Vector3.down, raycastLength, groundLayer))
    //    {
    //        //finishPos = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
    //        return true;
    //    }
    //    return false;
    //}
    public override void OnCollisionEnter(Collision collision)
    {
    //    if (collision.gameObject.tag == "EatBricks")
    //    {
    //        Debug.Log("Can Eat Bricks");
    //        rb.useGravity = false;
    //        playerChild.transform.localPosition = (playerChild.transform.localPosition.y + 1) * Vector3.up;
    //        collision.transform.parent = playerChild.transform.parent;
    //        collision.transform.localPosition = new Vector3(0, playerChild.transform.localPosition.y - 1, 0);
    //    }
    //    else if (collision.gameObject.tag == "LostBricks")
    //    {
    //        Debug.Log("Lost Bricks");
    //        rb.useGravity = false;
    //        playerChild.transform.localPosition = (playerChild.transform.localPosition.y - 1) * Vector3.up;
    //        Destroy(collision.gameObject);
    //        // Lấy danh sách các thành phần con
    //        Transform parentTransform = gameObject.transform;
    //        int childCount = parentTransform.childCount;
    //        //Debug.Log(childCount);
    //        if (childCount > 1)
    //        {
    //            // Lấy đối tượng con ở vị trí cuối cùng
    //            Transform lastChild = parentTransform.GetChild(childCount - 1);
    //            // Xóa đối tượng con
    //            Destroy(lastChild.gameObject);
    //        }
    //        else
    //        {
    //            Debug.LogError("Không có đối tượng con để xóa.");
    //        }
    //    }
    //    Debug.LogError(collision.gameObject.tag);
    //    //else if(collision.gameObject.tag == "FinishPlace")
    //    //{
    //    //    Debug.Log("Reaching into Finish Place");
    //    //    GameManager.Instance.SwitchState(GameManager.Instance.EndS);
    //    //}        
    }
}
