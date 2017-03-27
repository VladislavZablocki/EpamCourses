using System;

namespace task_DEV_12
{
    [Serializable]
    class ImpossibilityStepException : Exception
    {
        public ImpossibilityStepException() { }
        public ImpossibilityStepException   (string message) : base(message) { }

    }
}
