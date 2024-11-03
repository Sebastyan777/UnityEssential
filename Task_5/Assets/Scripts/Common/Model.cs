using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Common
{
    public class Model : MonoBehaviour
    {
        private Claw _claw;

        [Inject]
        private void Construct(Claw claw)
        {
            _claw = claw;
        }

        public void KeyArrowPressed(Vector3 direction)
        {
            _claw.transform.position += direction * Time.deltaTime * 5f;
        }

        public void ButtonPressed()
        {
            _claw.transform.position -= new Vector3(0, 2, 0);
        }
    }
}
