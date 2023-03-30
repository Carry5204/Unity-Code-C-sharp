using UnityEngine;

public class ShootObject : MonoBehaviour
{
    public GameObject Bullet; // 要發射的物件
    public float shootSpeed = 10f; // 物件發射速度
    public float shootInterval = 1f; // 物件發射間隔
    private float shootTimer; // 記錄物件發射時間

    private void Update()
    {
        // 更新發射計時器
        shootTimer += Time.deltaTime;

        // 按下發射按鈕且發射計時器大於發射間隔時
        if (Input.GetKeyDown(KeyCode.Space) && shootTimer > shootInterval)
        {
            // 重設發射計時器
            shootTimer = 0f;

            // 生成要發射的物件
            GameObject obj = Instantiate(Bullet, transform.position, Quaternion.identity);

            // 設定物件速度
            obj.GetComponent<Rigidbody2D>().velocity = Vector2.right * shootSpeed;
        }
    }
}