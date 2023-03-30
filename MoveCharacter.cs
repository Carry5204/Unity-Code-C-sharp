using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度
    private float horizontalInput; // 水平輸入值
    private float verticalInput; // 垂直輸入值

    private void Update()
    {
        // 讀取水平和垂直輸入值
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // 計算移動量並設定角色位置
        Vector3 moveAmount = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.position += moveAmount;
    }
}
