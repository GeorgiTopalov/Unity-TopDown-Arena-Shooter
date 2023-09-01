using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform player;

        //public float lerpSpeed = 1.0f;

        private Vector3 offset;

        private Vector3 targetPos;

        private void Start()
        {
            if (player == null) return;

            offset = transform.position - player.position;
        }



        private void Update()
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }

    }
}
