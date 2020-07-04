
using UnityEngine;

public class Player : MonoBehaviour
{
    #region 人物控制

    [Header("速度"),Tooltip("角色的移動速度")]
    public int speed=50;
    [Header("血量"),Tooltip("角色的血量呢"),Range(100.0f, 1500.0f)]
    public float hp=99.9f;
    public int coin;
    public float Jumpheight=500;
    [Header("音效區域")]
    public AudioClip audoJump;
    public AudioClip audoslide;
    public AudioClip audohit;
    [Header("角色死亡")]
    public bool death;

    #endregion

    #region 方法區域

    /// <summary>
    /// 角色的跳躍:跳躍音效，往上跳
    /// </summary>
    private void Jump()
    {
        print("跳躍");
    }
    /// <summary>
    /// 角色的滑行:縮小物體，
    /// </summary>
    private void Slide()
    {
        print("滑行");
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
        Jump();
    }

    private void Update()
    {
        Slide();
    }

    #endregion
}
