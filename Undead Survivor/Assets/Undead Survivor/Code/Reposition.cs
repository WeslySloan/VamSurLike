using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    Collider2D coll;
    void Awake()
    {
        coll = GetComponent<Collider2D>();
    }
    void OnTriggerExit2D(Collider2D collision)
    {

        if (!collision.CompareTag("Area"))
            return;
        Vector3 playerPos = GameManager.instance.player.transform.position;
        Vector3 myPos = transform.position;

        //float dirX = playerPos.x - myPos.x;
        //float dirY = playerPos.y - myPos.y;
        //float diffx = Mathf.Abs(dirX);
        //float diffy = Mathf.Abs(dirY);

        //dirX = dirX > 0 ? 1 : -1;
        //dirY = dirY > 0 ? 1 : -1;

        switch (transform.tag)
        {
            case "Ground":
                float dirX = playerPos.x - myPos.x;
                float dirY = playerPos.y - myPos.y;
                float diffx = Mathf.Abs(dirX);
                float diffy = Mathf.Abs(dirY);

                dirX = dirX > 0 ? 1 : -1;
                dirY = dirY > 0 ? 1 : -1;

                if (diffx > diffy)
                {
                    transform.Translate(Vector3.right * dirX * 40);
                }
                else if (diffx < diffy)
                {
                    transform.Translate(Vector3.up * dirY * 40);
                }
                break;
            case "Enemy":
                if(coll.enabled)
                {
                    Vector3 dist = playerPos - myPos;
                    Vector3 ran = new Vector3(Random.Range(-3, 3), 0);
                    transform.Translate(ran + dist * 2);
                }
                break;

        }
    }
}

//public class Reposition : MonoBehaviour
//{
//    Collider2D coll;
//    void Awake()
//    {
//        coll = GetComponent<Collider2D>();
//    }

//    void OnTriggerExit2D(Collider2D collision)
//    {
//        if (!collision.CompareTag("Area"))
//            return;

//        Vector3 playerPos = GameManager.instance.player.transform.position;
//        Vector3 myPos = transform.position;

//        //float dirX = playerPos.x - myPos.x;
//        //float dirY = playerPos.y - myPos.y;
//        //float diffx = Mathf.Abs(dirX);
//        //float diffy = Mathf.Abs(dirY);
//        //dirX = dirX > 0 ? 1 : -1;
//        //dirY = dirY > 0 ? 1 : -1;

//        float diffX = Mathf.Abs(playerPos.x - myPos.x);
//        float diffY = Mathf.Abs(playerPos.y - myPos.y);

//        Vector3 playerDir = GameManager.instance.player.inputVec;
//        float dirX = playerDir.x < 0 ? -1 : 1;
//        float dirY = playerDir.y < 0 ? -1 : 1;

//        switch (transform.tag)
//        {
//            case "Ground":
//                if (diffX > diffY)
//                {
//                    transform.Translate(Vector3.right * dirX * 40);
//                }
//                else if (diffX < diffY)
//                {
//                    transform.Translate(Vector3.up * dirY * 40);
//                }
//                else
//                {
//                    transform.Translate(Vector3.right * dirX * 40);
//                    transform.Translate(Vector3.up * dirY * 40);
//                }
//                break;

//            case "Enemy":
//                if (coll.enabled)
//                {
//                    transform.Translate(playerDir * 20 + new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0f));
//                }
//                break;
//        }


//    }
//}
