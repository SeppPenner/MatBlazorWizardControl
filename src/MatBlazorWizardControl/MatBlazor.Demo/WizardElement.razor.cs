// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WizardElement.razor.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The code behind class for the <see cref="WizardElement" /> page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MatBlazor.Demo
{
    using Microsoft.AspNetCore.Components;

    /// <summary>
    ///     The code behind class for the <see cref="WizardElement" /> page.
    /// </summary>
    public class WizardElementBase : ComponentBase
    {
        /// <summary>
        /// Gets or sets the current step.
        /// </summary>
        [Parameter]
        public int CurrentStep { get; set; }

        /// <summary>
        /// Gets or sets the step.
        /// </summary>
        [Parameter]
        public int Step { get; set; }

        /// <summary>
        /// Gets or sets the child content.
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
