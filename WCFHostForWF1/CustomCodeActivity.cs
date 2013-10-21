// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomCodeActivity.cs" company="None">
//   None
// </copyright>
// <summary>
//   The custom code activity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WCFHostForWF1
{
    using System;
    using System.Activities;
    using System.Diagnostics;

    /// <summary>
    /// The custom code activity.
    /// </summary>
    public sealed class CustomCodeActivity : CodeActivity
    {
        // Define an activity input argument of type string
        #region Public Properties

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public InArgument<string> Text { get; set; }

        #endregion

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        #region Methods

        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            var text = context.GetValue(this.Text);
            Debug.Print(string.Format("Changing WF status {0}", text));
        }

        #endregion
    }
}