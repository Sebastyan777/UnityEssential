using Common;
using UnityEngine;
using Zenject;

namespace Control
{
    public class InputDetector : MonoBehaviour
    {
        private Model _model;

        [Inject]
        private void Construct(Model model)
        {
            _model = model;
        }

        private void Update()
        {
            KeyPressDetect();
            ButtonPressDetect();
        }

        private void KeyPressDetect()
        {
            var h = Input.GetAxisRaw("Horizontal");
            var v = Input.GetAxisRaw("Vertical");

            if (h != 0f || v != 0f)
                _model.KeyArrowPressed(new Vector3(h, 0f, v));
        }

        private void ButtonPressDetect()
        {
            if (Input.GetKey("Jump"))
                _model.ButtonPressed();
        }
    }
}
