namespace VRTK.Examples
{
    using UnityEngine;

    public class Whirlygig : VRTK_InteractableObject
    {
        float spinSpeed = 0f;

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            spinSpeed = 360f;
            Debug.Log("NodeUI");
        }

        public override void StopUsing(VRTK_InteractUse usingObject)
        {
            base.StopUsing(usingObject);
            spinSpeed = 0f;
            Debug.Log("Off");
        }

        protected override void Update()
        {
            base.Update();
            
        }
    }
}