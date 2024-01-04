// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WizardControl.razor.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The code behind class for the <see cref="WizardControl" /> page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MatBlazor.Demo;

/// <summary>
///     The code behind class for the <see cref="WizardControl" /> page.
/// </summary>
public class WizardControlBase : ComponentBase
{
    /// <summary>
    /// The current step.
    /// </summary>
    private int currentStep;

    /// <summary>
    /// Gets or sets the child content.
    /// </summary>
    [Parameter]
    [NotNull]
    public RenderFragment? WizardElements { get; set; }

    /// <summary>
    /// Gets or sets the steps.
    /// </summary>
    [Parameter]
    public int Steps { get; set; }

    /// <summary>
    /// Gets or sets the current step.
    /// </summary>
    [Parameter]
#pragma warning disable BL0007 // Component parameters should be auto properties
    public int CurrentStep
#pragma warning restore BL0007 // Component parameters should be auto properties
    {
        get => this.currentStep;
        set
        {
            if (this.currentStep == value)
            {
                return;
            }

            this.currentStep = value;

            if (value == this.Steps)
            {
                this.Progress = 1;
            }
            else
            {
                var progress = value / (double)this.Steps * 100;
                this.Progress = progress > 1 ? 1 : progress;
            }

            this.StateHasChanged();
        }
    }

    /// <summary>
    /// Gets or sets the progress of the wizard.
    /// </summary>
    protected double Progress { get; set; }
}
