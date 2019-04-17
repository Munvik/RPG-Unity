
using UnityEngine;

public class Ruch : MonoBehaviour
{
    public float przyszpieszenie = 600f;
    public float maxPredkosc = 2000f;
    public float silaSkoku = 2000f;
    public Rigidbody2D rb;
    public Animator anim;

    bool naZiemi = false;
    float promienWykrywaczaZiemi = 0.5f;
    public LayerMask kontrolerKolizjiZiemi;
    public Transform wykrywaczZiemi;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        naZiemi = Physics2D.OverlapCircle(wykrywaczZiemi.position, promienWykrywaczaZiemi, kontrolerKolizjiZiemi);

        anim.SetFloat("PredkoscRuchu", Mathf.Abs(rb.velocity.x));
        anim.SetBool("Skok", !naZiemi);

   

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 move = new Vector2(przyszpieszenie * Time.deltaTime, 0);
            rb.AddForce(move);

            if (rb.velocity.x > maxPredkosc)
                rb.velocity = new Vector2(maxPredkosc, rb.velocity.y);

            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, 0f, transform.rotation.x));
    
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 move = new Vector2(-przyszpieszenie * Time.deltaTime, 0);
            rb.AddForce(move);

            if (rb.velocity.x < -maxPredkosc)
                rb.velocity = new Vector2(-maxPredkosc, rb.velocity.y);

            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, 180f, transform.rotation.x));
        }

        if (Input.GetKey(KeyCode.Space) && naZiemi)
        {
            Vector2 move = new Vector2(0, silaSkoku);
            rb.AddForce(move);
           
        }
    }
}
