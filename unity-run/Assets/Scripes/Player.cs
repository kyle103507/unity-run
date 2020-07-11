
using UnityEngine;

public class Player : MonoBehaviour
{
    #region 人物控制

    [Header("速度"), Tooltip("角色的移動速度")]
    public int speed = 50;

    [Header("血量"), Tooltip("角色的血量呢"), Range(100.0f, 1500.0f)]
    public float hp = 99.9f;
    public int coin;
    [Header("跳躍高度"), Range(100, 2000)]
    public float jumpheight = 500;

    [Header("音效區域")]
    public AudioClip audoJump;
    public AudioClip audoslide;
    public AudioClip audohit;

    [Header("角色死亡")]
    public bool death;

    [Header("動畫控制器")]
    public Animator ani;

    [Header("膠囊碰撞器")]
    public CapsuleCollider2D cc2d;

    [Header("剛體")]
    public Rigidbody2D rig;

    /// <summary>
    ///是否在地板上 
    /// </summary>
    public bool isGround;

    #endregion

    #region 方法區域

    private void Move()
    {
        //如果剛體,加速度,大小,小於10
        if (rig.velocity.magnitude < 7) ;
        {
            rig.AddForce(new Vector2(speed, 0));    //剛體,添加推力(二維向量)
        }

    }

    /// <summary>
    /// 角色的跳躍:跳躍音效，往上跳
    /// </summary>
    private void Jump()
    {
        // 布林值 = 輸入.取得按鍵(按鍵代碼列舉.空白建)
        bool jump = Input.GetKey(KeyCode.Space);

        ani.SetBool("跳躍開關", !isGround);

        //如果在地板上
        if (isGround)
        {
            if (jump)
            {
                isGround = false;                           //不在地板上
                rig.AddForce(new Vector2(0, jumpheight));   //剛體.添加推力(2維向量)
            }

        }

    }
    /// <summary>
    /// 角色的滑行:縮小物體，
    /// </summary>
    private void Slide()
    {
        // 布林值 = 輸入.取得按鍵(按鍵代碼列舉.左邊Ctrl)
        bool key = Input.GetKey(KeyCode.LeftControl);

        // 動畫控制器代碼
        ani.SetBool("滑行開關", key);

        if (key)            //如果 玩家 按下 左邊 Ctrl 就縮小
        {
            cc2d.offset = new Vector2(0.2763025f, -1.38f);       //位移
            cc2d.size = new Vector2(1.632579f, 2.2f);            //尺寸
        }
        //  否則 恢復
        else
        {
            cc2d.offset = new Vector2(0.276302f, -0.1228008f);  //位移
            cc2d.size = new Vector2(1.632579f, 4.455997f);      //尺寸
        }

    }
    /// <summary>
    /// 碰撞物體：扣血
    /// </summary>
    private void Hit()
    {

    }
    /// <summary>
    /// 角色吃金幣
    /// </summary>
    private void Eatcoin()
    {

    }
    /// <summary>
    /// 死亡:結束遊戲
    /// </summary>
    private void Dead()
    {

    }

    #endregion

    #region 事件區域

    private void Start()
    {


    }

    private void Update()
    {
        Slide();
    }

    /// <summary>
    ///固定更新事件:一秒固定執行50次，只要有剛體就寫在這
    /// </summary>
    private void FixedUpdate()
    {
        Jump();
        Move();

    }

    /// <summary>
    /// 碰撞事件:碰報物件開始執行一次
    /// </summary>
    /// <param name="collision"></param>碰到物件的碰撞資訊</paran>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //如果 碰到物件  的名稱 等於 "地板"
        if (collision.gameObject.name == "地板")
        {
            // 是否在地板上 = 是
            isGround = true;
        }
    }

    #endregion
}
