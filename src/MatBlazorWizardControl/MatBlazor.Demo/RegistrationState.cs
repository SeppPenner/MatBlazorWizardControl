// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegistrationState.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A class to store the state of the registration process.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MatBlazor.Demo
{
    /// <summary>
    ///     A class to store the state of the registration process.
    /// </summary>
    public class RegistrationState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationState"/> class.
        /// </summary>
        public RegistrationState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationState"/> class.
        /// </summary>
        /// <param name="steps">The steps.</param>
        public RegistrationState(int steps)
        {
            this.Steps = steps;
        }

        /// <summary>
        /// Gets or sets the current registration step.
        /// </summary>
        public int CurrentRegistrationStep { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the previous button is disabled or not.
        /// </summary>
        public bool PreviousButtonDisabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the next button is disabled or not.
        /// </summary>
        public bool NextButtonDisabled { get; set; }

        /// <summary>
        /// Gets or sets the steps.
        /// </summary>
        public int Steps { get; set; }
    }
}
