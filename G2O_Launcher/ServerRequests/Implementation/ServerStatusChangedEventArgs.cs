﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ServerStatusChangedEventArgs.cs" company="Gothic Online Project">
// //   
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace G2O_Launcher.ServerRequests.Implementation
{
    #region

    using System;

    using G2O_Launcher.ServerRequests.Interface;

    #endregion

    /// <summary>
    ///     Class that contains information about the changed status of a listened server.
    /// </summary>
    public class ServerStatusChangedEventArgs : EventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ServerStatusChangedEventArgs" />.
        /// </summary>
        /// <param name="changedStatus">The <see cref="IServerState" /> that has changed.</param>
        public ServerStatusChangedEventArgs(IServerState changedStatus)
        {
            this.ChangedStatus = changedStatus;
        }

        /// <summary>
        ///     Gets the changed <see cref="IServerState" />.
        /// </summary>
        public IServerState ChangedStatus { get; }
    }
}