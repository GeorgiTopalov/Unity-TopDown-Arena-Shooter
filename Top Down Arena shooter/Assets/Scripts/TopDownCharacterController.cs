using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        [SerializeField] public float speed = 10f;
        public Rigidbody2D rb;
        public Vector2 movement;


        private void Start()
        {
            rb = this.GetComponent<Rigidbody2D>();
        }


        private void Update()
        {
            movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        }

        private void FixedUpdate()
        {
            moveCharacter(movement);
        }

        void moveCharacter(Vector2 direction)
        {
            rb.velocity = direction * speed * Time.fixedDeltaTime;
        }
    }
}
