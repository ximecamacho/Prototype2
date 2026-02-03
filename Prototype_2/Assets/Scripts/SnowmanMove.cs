using UnityEngine;

public class SnowmanMove : MonoBehaviour
{
    [Header("Speed")]
    public float maxSpeed = 20f;

    [Header("Ice Feel (lower decel = more slippery)")]
    public float accel = 40f;        // how fast you speed up when holding input
    public float iceDecel = 1f;      // how fast you slow down when releasing input
    private Rigidbody2D rb;

    // Optional if you later want "not ice" without using physics materials:
    public bool useIce = true;
    public float groundDecel = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal"); // -1, 0, 1
        float vx = rb.linearVelocity.x;

        // accelerate toward target speed while input is held
        if (Mathf.Abs(input) > 0.01f)
        {
            float targetVx = input * maxSpeed;
            vx = Mathf.MoveTowards(vx, targetVx, accel * Time.fixedDeltaTime);
        }
        // otherwise, decelerate slowly (ice glide)
        else
        {
            float decel = useIce ? iceDecel : groundDecel;
            vx = Mathf.MoveTowards(vx, 0f, decel * Time.fixedDeltaTime);
        }

        rb.linearVelocity = new Vector2(vx, rb.linearVelocity.y);
        
    }
}
