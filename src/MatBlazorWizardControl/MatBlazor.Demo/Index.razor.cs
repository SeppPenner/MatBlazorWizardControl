// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Index.razor.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The code behind class for the <see cref="Index" /> page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MatBlazor.Demo
{
    using System;

    using Microsoft.AspNetCore.Components;

    /// <summary>
    /// The code behind class for the <see cref="Index" /> page.
    /// </summary>
    public class IndexBase : ComponentBase
    {
        /// <summary>
        /// Gets or sets the registration state.
        /// </summary>
        [CascadingParameter]
        public RegistrationState RegistrationState { get; set; } = new RegistrationState(2);

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        public ExampleParameters Parameters { get; set; } = new ExampleParameters();

        /// <summary>
        /// The method that is called when the button is clicked to go to the previous step.
        /// </summary>
        protected void OnGoToPreviousStep()
        {
            if (this.RegistrationState.CurrentRegistrationStep <= 0)
            {
                return;
            }

            this.RegistrationState.CurrentRegistrationStep -= 1;
            this.LockButtons();
            this.StateHasChanged();
        }

        /// <summary>
        /// The method that is called when the button is clicked to go to the next step.
        /// </summary>
        protected void OnGoToNextStep()
        {
            if (this.RegistrationState.CurrentRegistrationStep >= this.RegistrationState.Steps - 1)
            {
                return;
            }

            this.RegistrationState.CurrentRegistrationStep += 1;
            this.LockButtons();
            this.StateHasChanged();
        }

        /// <summary>
        /// An example method.
        /// </summary>
        protected void Something()
        {
            Console.WriteLine("Did something.");
        }

        /// <summary>
        /// A second example method.
        /// </summary>
        protected void SomethingElse()
        {
            Console.WriteLine("Did something else.");
        }

        /// <summary>
        /// Locks the buttons if necessary.
        /// </summary>
        private void LockButtons()
        {
            this.RegistrationState.PreviousButtonDisabled = this.RegistrationState.CurrentRegistrationStep == 0;
            this.RegistrationState.NextButtonDisabled = this.RegistrationState.CurrentRegistrationStep == this.RegistrationState.Steps - 1;
        }
    }
}