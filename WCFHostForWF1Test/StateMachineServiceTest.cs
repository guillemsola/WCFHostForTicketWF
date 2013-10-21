// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="None">
//   None
// </copyright>
// <summary>
//   The unit test 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WCFHostForWF1Test
{
    using System;
    using System.ServiceModel;

    using Microsoft.Activities.UnitTesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using WCFHostForWF1Test.ServiceReference1;

    /// <summary>
    /// The unit test 1.
    /// </summary>
    [TestClass]
    public class StateMachineServiceTest
    {
        #region Fields

        /// <summary>
        ///     The binding.
        /// </summary>
        private readonly NetNamedPipeBinding binding = new NetNamedPipeBinding();

        /// <summary>
        ///     The service uri.
        /// </summary>
        private readonly EndpointAddress serviceAddress =
            new EndpointAddress("net.pipe://localhost/IStateMachineService");

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The test method 1.
        /// </summary>
        [TestMethod]
        [DeploymentItem(@"WCFHostForWF1\StateMachineService.xamlx")]
        public void TestMethod1()
        {
            using (
                WorkflowServiceTestHost host = WorkflowServiceTestHost.Open(
                    "StateMachineService.xamlx", this.serviceAddress))
            {
                try
                {
                    // Arrange
                    var proxy = new StateMachineServiceClient(this.binding, this.serviceAddress);

                    Guid response = proxy.CreateFlow();

                    proxy.Close();

                    host.Close();

                    Assert.AreNotEqual(default(Guid), response);
                }
                finally 
                {
                    host.Tracking.Trace();
                }
            }
        }

        #endregion
    }
}