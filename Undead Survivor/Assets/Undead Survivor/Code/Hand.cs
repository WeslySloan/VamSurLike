using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public bool isLeft;
    public SpriteRenderer spriter;

    SpriteRenderer player;
    SpriteRenderer scanner;

    Vector3 rightPos = new Vector3(0.35f, -0.15f, 0);
    Vector3 rightPosReverse = new Vector3(-0.15f, -0.15f, 0);
    Quaternion leftRot = Quaternion.Euler(0, 0, -35);
    Quaternion leftRotReverse = Quaternion.Euler(0, 0, -135);


    void Awake()
    {
        player = GetComponentsInParent<SpriteRenderer>()[1];
    }

    void LateUpdate()
    {
        bool isReverse = player.flipX;


        if (isLeft) // 근접 무기 왼쪽 손
        {
            transform.localRotation = isReverse ? leftRotReverse : leftRot;
            spriter.flipY = isReverse;
            spriter.sortingOrder = isReverse ? 4 : 6;

        }

        else // 원거리 무기 오른쪽 손
        {
            transform.localPosition = isReverse ? rightPosReverse : rightPos;
            spriter.flipX = isReverse;
            spriter.sortingOrder = isReverse ? 6 : 4;
        }


    }

}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Hand : MonoBehaviour
//{
//    public bool isLeft;
//    public SpriteRenderer spriter;

//    SpriteRenderer player;
//    Scanner scanner;

//    Vector3 rightPos = new Vector3(0.35f, -0.15f, 0);
//    Vector3 rightPosReverse = new Vector3(-0.15f, -0.15f, 0);
//    Quaternion leftRot = Quaternion.Euler(0, 0, -35);
//    Quaternion leftRotReverse = Quaternion.Euler(0, 0, -135);

//    Transform currentTarget; // 🔥 목표를 유지할 변수
//    float targetLockTime = 0.2f; // 🔥 일정 시간 유지
//    float targetLockTimer = 0f;

//    void Awake()
//    {
//        player = GetComponentsInParent<SpriteRenderer>()[1];
//        scanner = player.GetComponentInParent<Scanner>();
//    }

//    void LateUpdate()
//    {
//        bool isReverse = player.flipX;

//        if (isLeft) // 근접 무기 (왼손)
//        {
//            transform.localRotation = isReverse ? leftRotReverse : leftRot;
//            spriter.flipY = isReverse;
//            spriter.sortingOrder = isReverse ? 4 : 6;
//        }
//        else
//        {
//            // 🔥 목표를 유지하는 로직
//            if (scanner != null && scanner.nearestTarget)
//            {
//                if (currentTarget == null || targetLockTimer <= 0)
//                {
//                    currentTarget = scanner.nearestTarget; // 새로운 목표 설정
//                    targetLockTimer = targetLockTime; // 타이머 초기화
//                }
//            }

//            // 🔥 목표물이 있다면 방향을 변경
//            if (currentTarget != null)
//            {
//                Vector3 targetPos = currentTarget.position;
//                Vector3 direction = targetPos - transform.position; // 방향 계산
//                transform.localRotation = Quaternion.FromToRotation(Vector3.left, direction); // 🔥 기준을 왼쪽으로 변경

//                // 총구 반전 여부
//                bool shouldFlipY = transform.localRotation.eulerAngles.z > 90 && transform.localRotation.eulerAngles.z < 270;
//                spriter.flipY = shouldFlipY;

//                spriter.sortingOrder = 6;
//            }
//            else
//            {
//                transform.localPosition = isReverse ? rightPosReverse : rightPos;
//                spriter.flipX = isReverse;
//                spriter.sortingOrder = isReverse ? 6 : 4;
//            }

//            // 🔥 목표 유지 타이머 감소
//            targetLockTimer -= Time.deltaTime;
//        }
//    }


//    public Vector3 GetFireDirection() // 🔥 총알 발사 방향 가져오기
//    {
//        return transform.right; // 현재 총구 방향과 일치
//    }
//}
