// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NativeActivity.cs" company="None">
//   None
// </copyright>
// <summary>
//   The native activity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace WCFHostForWF1
{
    using System;
    using System.Activities;
    using System.Diagnostics;

    /// <summary>
    ///     The native activity.
    /// </summary>
    public sealed class NativeActivity : NativeActivity<string>
    {
        #region Methods

        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        protected override void Execute(NativeActivityContext context)
        {
            var x = context.Properties;
            Debug.WriteLine("Native");
        }

        #endregion
    }
}